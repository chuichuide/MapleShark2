using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using Maple2.PacketLib.Tools;

namespace MapleShark2.Logging
{
    public sealed class StructureSegment
    {
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        // It is important that we do not use any functions that advance the reader position.
        // This allows us to avoid any copies of the underlying array.
        private readonly ByteReader reader;
        private readonly int length;

        public StructureSegment(in ArraySegment<byte> data, byte locale = MapleLocale.UNKNOWN)
        {
            reader = new ByteReader(data.Array, data.Offset);
            length = data.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private byte GetByte(int index)
        {
            return reader.Buffer[reader.Position + index];
        }

        public byte? Byte => length >= 1 ? reader.Peek<byte>() : null;
        public byte? Byte_XOR => length >= 1 ? (byte?)(reader.Peek<byte>() ^ 0x5A) : null;

        public sbyte? SByte => length >= 1 ? reader.Peek<sbyte>() : null;
        public sbyte? SByte_XOR => length >= 1 ? (sbyte?)(reader.Peek<sbyte>() ^ 0x5A) : null;

        public ushort? UShort => length >= 2 ? reader.Peek<ushort>() : null;
        public ushort? UShort_XOR => length >= 2 ? (ushort?)(reader.Peek<ushort>() ^ 0xA569) : null;

        public short? Short => length >= 2 ? reader.Peek<short>() : null;
        public short? Short_XOR => length >= 2 ? (short?)(reader.Peek<short>() ^ 0xA569) : null;

        public uint? UInt => length >= 4 ? reader.Peek<uint>() : null;
        public uint? UInt_XOR => length >= 4 ? reader.Peek<uint>() ^ 0x96CA5395 : null;

        public int? Int => length >= 4 ? reader.Peek<int>() : null;
        public int? Int_XOR => length >= 4 ? (int?)(reader.Peek<int>() ^ 0x96CA5395) : null;

        public float? Float => length >= 4 ? reader.Peek<float>() : null;

        public ulong? ULong => length >= 8 ? reader.Peek<ulong>() : null;

        public long? Long => length >= 8 ? reader.Peek<long>() : null;

        public string IpAddress => length == 4 ? $"{GetByte(0)}.{GetByte(1)}.{GetByte(2)}.{GetByte(3)}" : null;

        public DateTime? Date
        {
            get
            {
                try
                {
                    if (length >= 8)
                    {
                        return DateTime.FromFileTimeUtc(reader.Peek<long>());
                    }
                }
                catch
                {
                }

                return null;
            }
        }

        public DateTime? EpochDate
        {
            get
            {
                try
                {
                    if (length >= 8)
                    {
                        return epoch.AddSeconds(reader.Peek<long>());
                    }
                }
                catch
                {
                }

                return null;
            }
        }

        public string String
        {
            get
            {
                if (length == 0) return null;
                if (GetByte(0) == 0x00) return "";
                for (int index = 0; index < length; ++index)
                {
                    if (GetByte(index) == 0x00)
                    {
                        return Encoding.GetEncoding("big5").GetString(reader.Buffer, reader.Position, index);
                        // return Encoding.UTF8.GetString(reader.Buffer, reader.Position, index);
                    }
                }

                return Encoding.GetEncoding("big5").GetString(reader.Buffer, reader.Position, length);
                // return Encoding.UTF8.GetString(reader.Buffer, reader.Position, length);
            }
        }

        public string UnicodeString
        {
            get
            {
                if (length < 2) return null;
                if (GetByte(0) == 0x00 && GetByte(1) == 0x00) return "";
                for (int index = 0; index < length - 1; index += 2)
                {
                    if (GetByte(index) == 0x00 && GetByte(index + 1) == 0x00)
                    {
                        return Encoding.Unicode.GetString(reader.Buffer, reader.Position, index);
                    }
                }

                return Encoding.Unicode.GetString(reader.Buffer, reader.Position, length);
            }
        }

        public string StringIgnore
        {
            get
            {
                byte[] sBuffer = new byte[length];
                Buffer.BlockCopy(reader.Buffer, reader.Position, sBuffer, 0, length);
                if (sBuffer.Length == 0) return null;
                for (int index = 0; index < sBuffer.Length; ++index)
                {
                    if (sBuffer[index] < 0x20)
                    {
                        sBuffer[index] = 0x2E;
                    }
                }

                return Encoding.UTF8.GetString(sBuffer, 0, sBuffer.Length);
            }
        }

        public Color Color =>
            length < 4 ? default : Color.FromArgb(GetByte(3), GetByte(2), GetByte(1), GetByte(0));

        public string Length => length + (length != 1 ? " bytes" : " byte");
    }
}
﻿using uint8_t = System.Byte;
using uint16_t = System.UInt16;
using uint32_t = System.UInt32;
using uint64_t = System.UInt64;

using int8_t = System.SByte;
using int16_t = System.Int16;
using int32_t = System.Int32;
using int64_t = System.Int64;

using float32 = System.Single;

using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace DroneCAN
{
    public partial class DroneCAN
    {
        public partial class com_xckj_esc_OperateId : IDroneCANSerialize
        {
            public const int COM_XCKJ_ESC_OPERATEID_MAX_PACK_SIZE = 4;
            public const ulong COM_XCKJ_ESC_OPERATEID_DT_SIG = 0x4df8b5792b8e676a;
            public const int COM_XCKJ_ESC_OPERATEID_DT_ID = 20111;

            public uint8_t payload_len; [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] public uint8_t[] payload = Enumerable.Range(1, 3).Select(i => new uint8_t()).ToArray();

            public void encode(dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx, bool fdcan = false)
            {
                encode_com_xckj_esc_OperateId(this, chunk_cb, ctx, fdcan);
            }
            public void decode(CanardRxTransfer transfer, bool fdcan = false)
            {
                decode_com_xckj_esc_OperateId(transfer, this, fdcan);
            }
            public static com_xckj_esc_OperateId ByteArrayToDroneCANMsg(byte[] transfer, int startoffset, bool fdcan = false)
            {
                var ans = new com_xckj_esc_OperateId();
                ans.decode(new DroneCAN.CanardRxTransfer(transfer.Skip(startoffset).ToArray()), fdcan);
                return ans;
            }
        }
    }

}

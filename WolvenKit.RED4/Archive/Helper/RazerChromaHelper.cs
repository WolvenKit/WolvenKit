using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Archive;

public static class RazerChromaHelper
{
    public static EChromaSDKDeviceEnum GetDevice(byte deviceType, byte device)
    {
        return deviceType switch
        {
            (byte)EChromaSDKDeviceTypeEnum.DE_1D => device switch
            {
                (byte)EChromaSDKDevice1DEnum.DE_ChromaLink =>
                    EChromaSDKDeviceEnum.DE_ChromaLink,
                (byte)EChromaSDKDevice1DEnum.DE_Headset =>
                    EChromaSDKDeviceEnum.DE_Headset,
                (byte)EChromaSDKDevice1DEnum.DE_Mousepad =>
                    EChromaSDKDeviceEnum.DE_Mousepad,
                _ => throw new ArgumentOutOfRangeException(nameof(device), device, null)
            },
            (byte)EChromaSDKDeviceTypeEnum.DE_2D => device switch
            {
                (byte)EChromaSDKDevice2DEnum.DE_Keyboard =>
                    EChromaSDKDeviceEnum.DE_Keyboard,
                (byte)EChromaSDKDevice2DEnum.DE_Keypad =>
                    EChromaSDKDeviceEnum.DE_Keypad,
                (byte)EChromaSDKDevice2DEnum.DE_Mouse =>
                    EChromaSDKDeviceEnum.DE_Mouse,
                (byte)EChromaSDKDevice2DEnum.DE_KeyboardExtended =>
                    EChromaSDKDeviceEnum.DE_KeyboardExtended,
                _ => throw new ArgumentOutOfRangeException(nameof(device), device, null)
            },
            _ => throw new ArgumentOutOfRangeException(nameof(deviceType), deviceType, null)
        };
    }

    public static (byte DeviceType, byte Device) GetDeviceInfo(EChromaSDKDeviceEnum device)
    {
        switch (device)
        {
            case EChromaSDKDeviceEnum.DE_ChromaLink:
                return ((byte)EChromaSDKDeviceTypeEnum.DE_1D, (byte)EChromaSDKDevice1DEnum.DE_ChromaLink);
            case EChromaSDKDeviceEnum.DE_Headset:
                return ((byte)EChromaSDKDeviceTypeEnum.DE_1D, (byte)EChromaSDKDevice1DEnum.DE_Headset);
            case EChromaSDKDeviceEnum.DE_Keyboard:
                return ((byte)EChromaSDKDeviceTypeEnum.DE_2D, (byte)EChromaSDKDevice2DEnum.DE_Keyboard);
            case EChromaSDKDeviceEnum.DE_Keypad:
                return ((byte)EChromaSDKDeviceTypeEnum.DE_2D, (byte)EChromaSDKDevice2DEnum.DE_Keypad);
            case EChromaSDKDeviceEnum.DE_Mouse:
                return ((byte)EChromaSDKDeviceTypeEnum.DE_2D, (byte)EChromaSDKDevice2DEnum.DE_Mouse);
            case EChromaSDKDeviceEnum.DE_Mousepad:
                return ((byte)EChromaSDKDeviceTypeEnum.DE_1D, (byte)EChromaSDKDevice1DEnum.DE_Mousepad);
            case EChromaSDKDeviceEnum.DE_KeyboardExtended:
                return ((byte)EChromaSDKDeviceTypeEnum.DE_2D, (byte)EChromaSDKDevice2DEnum.DE_KeyboardExtended);
            default:
                throw new ArgumentOutOfRangeException(nameof(device), device, null);
        }
    }

    public static (int RowCount, int ColumnCount) GetRowAndColumnCount(EChromaSDKDeviceEnum deviceType)
    {
        return deviceType switch
        {
            EChromaSDKDeviceEnum.DE_ChromaLink => (1, 5),
            EChromaSDKDeviceEnum.DE_Headset => (1, 5),
            EChromaSDKDeviceEnum.DE_Keyboard => (6, 22),
            EChromaSDKDeviceEnum.DE_Keypad => (4, 5),
            EChromaSDKDeviceEnum.DE_Mouse => (9, 7),
            EChromaSDKDeviceEnum.DE_Mousepad => (1, 15),
            EChromaSDKDeviceEnum.DE_KeyboardExtended => (8, 24),
            _ => throw new ArgumentOutOfRangeException(nameof(deviceType), deviceType, null)
        };
    }
}
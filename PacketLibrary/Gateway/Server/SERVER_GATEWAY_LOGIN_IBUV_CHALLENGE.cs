using PacketLibrary.Enums;
using SilkroadSecurityAPI;

namespace PacketLibrary.Gateway.Server;

public class SERVER_GATEWAY_LOGIN_IBUV_CHALLENGE : IPacketStructure
{
    public static ushort MsgId => 0x2322;
    public static bool Encrypted => false;
    public static bool Massive => false;
    public PacketDirection FromDirection => PacketDirection.Server;
    public PacketDirection ToDirection => PacketDirection.Client;

    public Task Read(Packet packet)
    {
        throw new NotImplementedException();
    }

    public Packet Build()
    {
        throw new NotImplementedException();
    }

    public static async Task<Packet> of()
    {
        throw new NotImplementedException();
    }
}

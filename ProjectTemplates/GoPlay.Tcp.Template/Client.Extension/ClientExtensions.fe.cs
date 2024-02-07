// Code generated by GoPlay Protocol Extension Generator. DO NOT EDIT.
using System;
using System.Threading.Tasks;
using GoPlay;
using GoPlay.Core.Protocols;

namespace GoPlayProj.Extension.Backend
{
    public static partial class ProtocolConsts
    {
        //Protocols
        public const string Time_GetTime = "time.utc.now";
        public const string Echo_Request = "echo.request";
        public const string Echo_Notify = "echo.notify";
        public const string Echo_Timeout = "echo.timeout";
        public const string Echo_Err = "echo.err";
        
        //Pushes
        public const string Push_EchoPush = "echo.push";
    }

    public static partial class ClientExtensions
    {
        public static Task<(Status, PbTime)> Time_GetTime(this Client cli)
        {
            return cli.Request<PbTime>(ProtocolConsts.Time_GetTime);
        }

        public static Task<(Status, PbString)> Echo_Request(this Client cli, PbString arg)
        {
            return cli.Request<PbString, PbString>(ProtocolConsts.Echo_Request, arg);
        }

        public static void Echo_Notify(this Client cli, PbString arg)
        {
            cli.Notify(ProtocolConsts.Echo_Notify, arg);
        }

        public static Task<(Status, PbString)> Echo_Timeout(this Client cli, PbString arg)
        {
            return cli.Request<PbString, PbString>(ProtocolConsts.Echo_Timeout, arg);
        }

        public static Task<(Status, PbString)> Echo_Err(this Client cli, PbString arg)
        {
            return cli.Request<PbString, PbString>(ProtocolConsts.Echo_Err, arg);
        }

        
    }
}
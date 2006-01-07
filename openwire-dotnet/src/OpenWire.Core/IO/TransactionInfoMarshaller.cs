//
// Marshalling code for Open Wire Format for TransactionInfo
//
//
// NOTE!: This file is autogenerated - do not modify!
//        if you need to make a change, please see the Groovy scripts in the
//        activemq-openwire module
//

using System;
using System.Collections;
using System.IO;

using OpenWire.Core;
using OpenWire.Core.Commands;
using OpenWire.Core.IO;

namespace OpenWire.Core.IO
{
    public class TransactionInfoMarshaller : AbstractCommandMarshaller
    {


        public override Command CreateCommand() {
            return new TransactionInfo();
        }

        public override void BuildCommand(Command command, BinaryReader dataIn) {
            base.BuildCommand(command, dataIn);

            TransactionInfo info = (TransactionInfo) command;
            info.ConnectionId = (ConnectionId) CommandMarshallerRegistry.ConnectionIdMarshaller.ReadCommand(dataIn);
            info.TransactionId = (TransactionId) CommandMarshallerRegistry.TransactionIdMarshaller.ReadCommand(dataIn);
            info.Type = dataIn.ReadByte();

        }

        public override void WriteCommand(Command command, BinaryWriter dataOut) {
            base.WriteCommand(command, dataOut);

            TransactionInfo info = (TransactionInfo) command;
            CommandMarshallerRegistry.ConnectionIdMarshaller.WriteCommand(info.ConnectionId, dataOut);
            CommandMarshallerRegistry.TransactionIdMarshaller.WriteCommand(info.TransactionId, dataOut);
            dataOut.Write(info.Type);

        }
    }
}

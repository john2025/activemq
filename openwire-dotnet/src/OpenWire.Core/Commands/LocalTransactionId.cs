//
// Marshalling code for Open Wire Format for LocalTransactionId
//
//
// NOTE!: This file is autogenerated - do not modify!
//        if you need to make a change, please see the Groovy scripts in the
//        activemq-openwire module
//

using System;
using System.Collections;

using OpenWire.Core;

namespace OpenWire.Core.Commands
{
    public class LocalTransactionId : AbstractCommand
    {
    			public const int ID_LocalTransactionId = 1;
    			
        long transactionId;
        ConnectionId connectionId;



        // TODO generate Equals method
        // TODO generate GetHashCode method
        // TODO generate ToString method


        public override int GetCommandType() {
            return ID_LocalTransactionId;
        }


        // Properties

        public long TransactionId
        {
            get
            {
                return transactionId;
            }
            set
            {
                transactionId = value;
            }            
        }

        public ConnectionId ConnectionId
        {
            get
            {
                return connectionId;
            }
            set
            {
                connectionId = value;
            }            
        }

    }
}

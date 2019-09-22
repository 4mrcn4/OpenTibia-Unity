﻿namespace OpenTibiaUnity.Core.Store.OpenParameters
{
    public class StoreOfferIdOpenParamater : IStoreOpenParamater
    {
        uint _offerId;

        public uint OfferId { get => _offerId; }

        public StoreOfferIdOpenParamater(uint offerId) {
            _offerId = offerId;
        }

        public void WriteToMessage(Communication.Internal.ByteArray message) {
            message.WriteUnsignedInt(_offerId);
        }
    }
}

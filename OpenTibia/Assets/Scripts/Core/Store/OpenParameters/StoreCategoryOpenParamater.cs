﻿namespace OpenTibiaUnity.Core.Store.OpenParameters
{
    public class StoreCategoryNameOpenParamater : IStoreOpenParamater
    {
        string _category;

        public string Category { get => _category; }

        public StoreCategoryNameOpenParamater(string category) {
            _category = category;
        }

        public void WriteToMessage(Communication.Internal.ByteArray message) {
            message.WriteString(_category);
        }
    }
}

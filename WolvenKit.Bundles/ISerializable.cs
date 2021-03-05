using System.IO;

namespace WolvenKit.Bundles
{
    internal interface ICsvSerializable
    {
        #region Methods

        void DeserializeFromCsv(StreamReader reader);

        void SerializeToCsv(StreamWriter writer);

        #endregion Methods
    }

    internal interface ISerializable
    {
        #region Methods

        void Deserialize(BinaryReader reader);

        void Serialize(BinaryWriter writer);

        #endregion Methods
    }
}

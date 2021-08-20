using System.IO;

namespace WolvenKit.RED4.TweakDB.Types
{
    public interface IType
    {
        /// <summary>
        /// The native name of the type.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Serialize the type.
        /// </summary>
        /// <param name="writer">The writer.</param>
        void Serialize(BinaryWriter writer);
    }
}

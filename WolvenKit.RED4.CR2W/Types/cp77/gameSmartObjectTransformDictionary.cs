using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectTransformDictionary : ISerializable
	{
		private CArray<gameSmartObjectTransformDictionaryTransformEntry> _transforms;

		[Ordinal(0)] 
		[RED("transforms")] 
		public CArray<gameSmartObjectTransformDictionaryTransformEntry> Transforms
		{
			get => GetProperty(ref _transforms);
			set => SetProperty(ref _transforms, value);
		}

		public gameSmartObjectTransformDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

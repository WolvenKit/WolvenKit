using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CResource : ISerializable
	{
		private CEnum<ECookingPlatform> _cookingPlatform;

		[Ordinal(0)] 
		[RED("cookingPlatform")] 
		public CEnum<ECookingPlatform> CookingPlatform
		{
			get => GetProperty(ref _cookingPlatform);
			set => SetProperty(ref _cookingPlatform, value);
		}

		public CResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

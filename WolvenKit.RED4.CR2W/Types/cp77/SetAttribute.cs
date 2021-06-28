using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetAttribute : gamePlayerScriptableSystemRequest
	{
		private CFloat _statLevel;
		private CEnum<gamedataStatType> _attributeType;

		[Ordinal(1)] 
		[RED("statLevel")] 
		public CFloat StatLevel
		{
			get => GetProperty(ref _statLevel);
			set => SetProperty(ref _statLevel, value);
		}

		[Ordinal(2)] 
		[RED("attributeType")] 
		public CEnum<gamedataStatType> AttributeType
		{
			get => GetProperty(ref _attributeType);
			set => SetProperty(ref _attributeType, value);
		}

		public SetAttribute(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

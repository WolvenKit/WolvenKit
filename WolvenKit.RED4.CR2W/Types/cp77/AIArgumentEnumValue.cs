using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIArgumentEnumValue : AIArgumentDefinition
	{
		private CEnum<AIArgumentType> _type;
		private CName _enumClass;
		private CInt64 _defaultValue;

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<AIArgumentType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(4)] 
		[RED("enumClass")] 
		public CName EnumClass
		{
			get => GetProperty(ref _enumClass);
			set => SetProperty(ref _enumClass, value);
		}

		[Ordinal(5)] 
		[RED("defaultValue")] 
		public CInt64 DefaultValue
		{
			get => GetProperty(ref _defaultValue);
			set => SetProperty(ref _defaultValue, value);
		}

		public AIArgumentEnumValue(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

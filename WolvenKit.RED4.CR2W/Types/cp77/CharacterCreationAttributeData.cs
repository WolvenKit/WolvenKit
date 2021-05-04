using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationAttributeData : IScriptable
	{
		private CString _label;
		private CString _desc;
		private CInt32 _value;
		private CEnum<gamedataStatType> _attribute;
		private CName _icon;
		private CInt32 _maxValue;
		private CInt32 _minValue;
		private CBool _maxed;
		private CBool _atMinimum;

		[Ordinal(0)] 
		[RED("label")] 
		public CString Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(1)] 
		[RED("desc")] 
		public CString Desc
		{
			get => GetProperty(ref _desc);
			set => SetProperty(ref _desc, value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(3)] 
		[RED("attribute")] 
		public CEnum<gamedataStatType> Attribute
		{
			get => GetProperty(ref _attribute);
			set => SetProperty(ref _attribute, value);
		}

		[Ordinal(4)] 
		[RED("icon")] 
		public CName Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(5)] 
		[RED("maxValue")] 
		public CInt32 MaxValue
		{
			get => GetProperty(ref _maxValue);
			set => SetProperty(ref _maxValue, value);
		}

		[Ordinal(6)] 
		[RED("minValue")] 
		public CInt32 MinValue
		{
			get => GetProperty(ref _minValue);
			set => SetProperty(ref _minValue, value);
		}

		[Ordinal(7)] 
		[RED("maxed")] 
		public CBool Maxed
		{
			get => GetProperty(ref _maxed);
			set => SetProperty(ref _maxed, value);
		}

		[Ordinal(8)] 
		[RED("atMinimum")] 
		public CBool AtMinimum
		{
			get => GetProperty(ref _atMinimum);
			set => SetProperty(ref _atMinimum, value);
		}

		public CharacterCreationAttributeData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

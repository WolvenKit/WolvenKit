using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AttributeData : IDisplayData
	{
		private CString _label;
		private CString _icon;
		private TweakDBID _id;
		private CInt32 _value;
		private CInt32 _maxValue;
		private CString _description;
		private CBool _availableToUpgrade;
		private CEnum<gamedataStatType> _type;

		[Ordinal(0)] 
		[RED("label")] 
		public CString Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(1)] 
		[RED("icon")] 
		public CString Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(2)] 
		[RED("id")] 
		public TweakDBID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(3)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(4)] 
		[RED("maxValue")] 
		public CInt32 MaxValue
		{
			get => GetProperty(ref _maxValue);
			set => SetProperty(ref _maxValue, value);
		}

		[Ordinal(5)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(6)] 
		[RED("availableToUpgrade")] 
		public CBool AvailableToUpgrade
		{
			get => GetProperty(ref _availableToUpgrade);
			set => SetProperty(ref _availableToUpgrade, value);
		}

		[Ordinal(7)] 
		[RED("type")] 
		public CEnum<gamedataStatType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public AttributeData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

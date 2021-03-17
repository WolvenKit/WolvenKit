using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SAttribute : CVariable
	{
		private CEnum<gamedataStatType> _attributeName;
		private CInt32 _value;
		private TweakDBID _id;

		[Ordinal(0)] 
		[RED("attributeName")] 
		public CEnum<gamedataStatType> AttributeName
		{
			get => GetProperty(ref _attributeName);
			set => SetProperty(ref _attributeName, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(2)] 
		[RED("id")] 
		public TweakDBID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		public SAttribute(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

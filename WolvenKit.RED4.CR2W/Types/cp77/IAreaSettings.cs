using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IAreaSettings : ISerializable
	{
		private CBool _enable;
		private CUInt64 _disabledIndexedProperties;

		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(1)] 
		[RED("disabledIndexedProperties")] 
		public CUInt64 DisabledIndexedProperties
		{
			get => GetProperty(ref _disabledIndexedProperties);
			set => SetProperty(ref _disabledIndexedProperties, value);
		}

		public IAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

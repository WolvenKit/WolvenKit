using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldITriggerAreaNotifer : IScriptable
	{
		private CBool _isEnabled;
		private CEnum<TriggerChannel> _includeChannels;
		private CUInt32 _excludeChannels;

		[Ordinal(0)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(1)] 
		[RED("includeChannels")] 
		public CEnum<TriggerChannel> IncludeChannels
		{
			get => GetProperty(ref _includeChannels);
			set => SetProperty(ref _includeChannels, value);
		}

		[Ordinal(2)] 
		[RED("excludeChannels")] 
		public CUInt32 ExcludeChannels
		{
			get => GetProperty(ref _excludeChannels);
			set => SetProperty(ref _excludeChannels, value);
		}

		public worldITriggerAreaNotifer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

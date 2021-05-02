using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DebugOutlineEvent : redEvent
	{
		private CEnum<EOutlineType> _type;
		private CFloat _opacity;
		private entEntityID _requester;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<EOutlineType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get => GetProperty(ref _opacity);
			set => SetProperty(ref _opacity, value);
		}

		[Ordinal(2)] 
		[RED("requester")] 
		public entEntityID Requester
		{
			get => GetProperty(ref _requester);
			set => SetProperty(ref _requester, value);
		}

		public DebugOutlineEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

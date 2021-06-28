using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimSoundEvent : entSoundEvent
	{
		private CName _metadataContext;

		[Ordinal(4)] 
		[RED("metadataContext")] 
		public CName MetadataContext
		{
			get => GetProperty(ref _metadataContext);
			set => SetProperty(ref _metadataContext, value);
		}

		public entAnimSoundEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

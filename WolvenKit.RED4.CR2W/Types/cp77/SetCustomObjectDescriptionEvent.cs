using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetCustomObjectDescriptionEvent : redEvent
	{
		private CHandle<ObjectScanningDescription> _objectDescription;

		[Ordinal(0)] 
		[RED("objectDescription")] 
		public CHandle<ObjectScanningDescription> ObjectDescription
		{
			get => GetProperty(ref _objectDescription);
			set => SetProperty(ref _objectDescription, value);
		}

		public SetCustomObjectDescriptionEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

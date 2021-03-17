using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTeleportPuppetParams : CVariable
	{
		private CHandle<questUniversalRef> _destinationRef;
		private Vector3 _destinationOffset;

		[Ordinal(0)] 
		[RED("destinationRef")] 
		public CHandle<questUniversalRef> DestinationRef
		{
			get => GetProperty(ref _destinationRef);
			set => SetProperty(ref _destinationRef, value);
		}

		[Ordinal(1)] 
		[RED("destinationOffset")] 
		public Vector3 DestinationOffset
		{
			get => GetProperty(ref _destinationOffset);
			set => SetProperty(ref _destinationOffset, value);
		}

		public questTeleportPuppetParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

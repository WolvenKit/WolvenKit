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
			get
			{
				if (_destinationRef == null)
				{
					_destinationRef = (CHandle<questUniversalRef>) CR2WTypeManager.Create("handle:questUniversalRef", "destinationRef", cr2w, this);
				}
				return _destinationRef;
			}
			set
			{
				if (_destinationRef == value)
				{
					return;
				}
				_destinationRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("destinationOffset")] 
		public Vector3 DestinationOffset
		{
			get
			{
				if (_destinationOffset == null)
				{
					_destinationOffset = (Vector3) CR2WTypeManager.Create("Vector3", "destinationOffset", cr2w, this);
				}
				return _destinationOffset;
			}
			set
			{
				if (_destinationOffset == value)
				{
					return;
				}
				_destinationOffset = value;
				PropertySet(this);
			}
		}

		public questTeleportPuppetParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

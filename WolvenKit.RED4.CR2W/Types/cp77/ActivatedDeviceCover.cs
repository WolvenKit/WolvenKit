using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceCover : ActivatedDeviceTransfromAnim
	{
		private CHandle<AIOffMeshConnectionComponent> _offMeshConnection;

		[Ordinal(94)] 
		[RED("offMeshConnection")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnection
		{
			get
			{
				if (_offMeshConnection == null)
				{
					_offMeshConnection = (CHandle<AIOffMeshConnectionComponent>) CR2WTypeManager.Create("handle:AIOffMeshConnectionComponent", "offMeshConnection", cr2w, this);
				}
				return _offMeshConnection;
			}
			set
			{
				if (_offMeshConnection == value)
				{
					return;
				}
				_offMeshConnection = value;
				PropertySet(this);
			}
		}

		public ActivatedDeviceCover(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendingTerminal : InteractiveDevice
	{
		private Vector4 _position;
		private CHandle<entMeshComponent> _canMeshComponent;
		private CArray<CEnum<EVendorMode>> _vendingBlacklist;

		[Ordinal(93)] 
		[RED("position")] 
		public Vector4 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector4) CR2WTypeManager.Create("Vector4", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("canMeshComponent")] 
		public CHandle<entMeshComponent> CanMeshComponent
		{
			get
			{
				if (_canMeshComponent == null)
				{
					_canMeshComponent = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "canMeshComponent", cr2w, this);
				}
				return _canMeshComponent;
			}
			set
			{
				if (_canMeshComponent == value)
				{
					return;
				}
				_canMeshComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("vendingBlacklist")] 
		public CArray<CEnum<EVendorMode>> VendingBlacklist
		{
			get
			{
				if (_vendingBlacklist == null)
				{
					_vendingBlacklist = (CArray<CEnum<EVendorMode>>) CR2WTypeManager.Create("array:EVendorMode", "vendingBlacklist", cr2w, this);
				}
				return _vendingBlacklist;
			}
			set
			{
				if (_vendingBlacklist == value)
				{
					return;
				}
				_vendingBlacklist = value;
				PropertySet(this);
			}
		}

		public VendingTerminal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

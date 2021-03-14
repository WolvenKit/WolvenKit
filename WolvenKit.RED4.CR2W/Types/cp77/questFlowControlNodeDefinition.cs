using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questFlowControlNodeDefinition : questDisableableNodeDefinition
	{
		private CBool _isOpen;
		private CUInt16 _opensAt;
		private CUInt16 _closesAt;

		[Ordinal(2)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get
			{
				if (_isOpen == null)
				{
					_isOpen = (CBool) CR2WTypeManager.Create("Bool", "isOpen", cr2w, this);
				}
				return _isOpen;
			}
			set
			{
				if (_isOpen == value)
				{
					return;
				}
				_isOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("opensAt")] 
		public CUInt16 OpensAt
		{
			get
			{
				if (_opensAt == null)
				{
					_opensAt = (CUInt16) CR2WTypeManager.Create("Uint16", "opensAt", cr2w, this);
				}
				return _opensAt;
			}
			set
			{
				if (_opensAt == value)
				{
					return;
				}
				_opensAt = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("closesAt")] 
		public CUInt16 ClosesAt
		{
			get
			{
				if (_closesAt == null)
				{
					_closesAt = (CUInt16) CR2WTypeManager.Create("Uint16", "closesAt", cr2w, this);
				}
				return _closesAt;
			}
			set
			{
				if (_closesAt == value)
				{
					return;
				}
				_closesAt = value;
				PropertySet(this);
			}
		}

		public questFlowControlNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

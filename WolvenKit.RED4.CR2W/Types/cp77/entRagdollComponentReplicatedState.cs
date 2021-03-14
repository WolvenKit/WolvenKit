using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entRagdollComponentReplicatedState : netIComponentState
	{
		private CArray<Transform> _transforms;
		private CBool _isSleeping;

		[Ordinal(2)] 
		[RED("transforms")] 
		public CArray<Transform> Transforms
		{
			get
			{
				if (_transforms == null)
				{
					_transforms = (CArray<Transform>) CR2WTypeManager.Create("array:Transform", "transforms", cr2w, this);
				}
				return _transforms;
			}
			set
			{
				if (_transforms == value)
				{
					return;
				}
				_transforms = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isSleeping")] 
		public CBool IsSleeping
		{
			get
			{
				if (_isSleeping == null)
				{
					_isSleeping = (CBool) CR2WTypeManager.Create("Bool", "isSleeping", cr2w, this);
				}
				return _isSleeping;
			}
			set
			{
				if (_isSleeping == value)
				{
					return;
				}
				_isSleeping = value;
				PropertySet(this);
			}
		}

		public entRagdollComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCollisionGroupEntry : CVariable
	{
		private NodeRef _neRef;
		private CBool _reversed;

		[Ordinal(0)] 
		[RED("neRef")] 
		public NodeRef NeRef
		{
			get
			{
				if (_neRef == null)
				{
					_neRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "neRef", cr2w, this);
				}
				return _neRef;
			}
			set
			{
				if (_neRef == value)
				{
					return;
				}
				_neRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("Reversed")] 
		public CBool Reversed
		{
			get
			{
				if (_reversed == null)
				{
					_reversed = (CBool) CR2WTypeManager.Create("Bool", "Reversed", cr2w, this);
				}
				return _reversed;
			}
			set
			{
				if (_reversed == value)
				{
					return;
				}
				_reversed = value;
				PropertySet(this);
			}
		}

		public worldCollisionGroupEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

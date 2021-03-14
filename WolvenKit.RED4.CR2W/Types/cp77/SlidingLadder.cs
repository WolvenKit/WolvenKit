using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SlidingLadder : BaseAnimatedDevice
	{
		private CHandle<AIOffMeshConnectionComponent> _offMeshConnectionDown;
		private CHandle<AIOffMeshConnectionComponent> _offMeshConnectionUp;
		private CHandle<gameinteractionsComponent> _ladderInteraction;
		private CBool _wasShot;

		[Ordinal(98)] 
		[RED("offMeshConnectionDown")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionDown
		{
			get
			{
				if (_offMeshConnectionDown == null)
				{
					_offMeshConnectionDown = (CHandle<AIOffMeshConnectionComponent>) CR2WTypeManager.Create("handle:AIOffMeshConnectionComponent", "offMeshConnectionDown", cr2w, this);
				}
				return _offMeshConnectionDown;
			}
			set
			{
				if (_offMeshConnectionDown == value)
				{
					return;
				}
				_offMeshConnectionDown = value;
				PropertySet(this);
			}
		}

		[Ordinal(99)] 
		[RED("offMeshConnectionUp")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionUp
		{
			get
			{
				if (_offMeshConnectionUp == null)
				{
					_offMeshConnectionUp = (CHandle<AIOffMeshConnectionComponent>) CR2WTypeManager.Create("handle:AIOffMeshConnectionComponent", "offMeshConnectionUp", cr2w, this);
				}
				return _offMeshConnectionUp;
			}
			set
			{
				if (_offMeshConnectionUp == value)
				{
					return;
				}
				_offMeshConnectionUp = value;
				PropertySet(this);
			}
		}

		[Ordinal(100)] 
		[RED("ladderInteraction")] 
		public CHandle<gameinteractionsComponent> LadderInteraction
		{
			get
			{
				if (_ladderInteraction == null)
				{
					_ladderInteraction = (CHandle<gameinteractionsComponent>) CR2WTypeManager.Create("handle:gameinteractionsComponent", "ladderInteraction", cr2w, this);
				}
				return _ladderInteraction;
			}
			set
			{
				if (_ladderInteraction == value)
				{
					return;
				}
				_ladderInteraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(101)] 
		[RED("wasShot")] 
		public CBool WasShot
		{
			get
			{
				if (_wasShot == null)
				{
					_wasShot = (CBool) CR2WTypeManager.Create("Bool", "wasShot", cr2w, this);
				}
				return _wasShot;
			}
			set
			{
				if (_wasShot == value)
				{
					return;
				}
				_wasShot = value;
				PropertySet(this);
			}
		}

		public SlidingLadder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

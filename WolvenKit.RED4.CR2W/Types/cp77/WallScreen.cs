using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WallScreen : TV
	{
		private SMovementPattern _movementPattern;
		private CName _factOnFullyOpened;
		private CHandle<ObjectMoverComponent> _objectMover;

		[Ordinal(102)] 
		[RED("movementPattern")] 
		public SMovementPattern MovementPattern
		{
			get
			{
				if (_movementPattern == null)
				{
					_movementPattern = (SMovementPattern) CR2WTypeManager.Create("SMovementPattern", "movementPattern", cr2w, this);
				}
				return _movementPattern;
			}
			set
			{
				if (_movementPattern == value)
				{
					return;
				}
				_movementPattern = value;
				PropertySet(this);
			}
		}

		[Ordinal(103)] 
		[RED("factOnFullyOpened")] 
		public CName FactOnFullyOpened
		{
			get
			{
				if (_factOnFullyOpened == null)
				{
					_factOnFullyOpened = (CName) CR2WTypeManager.Create("CName", "factOnFullyOpened", cr2w, this);
				}
				return _factOnFullyOpened;
			}
			set
			{
				if (_factOnFullyOpened == value)
				{
					return;
				}
				_factOnFullyOpened = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("objectMover")] 
		public CHandle<ObjectMoverComponent> ObjectMover
		{
			get
			{
				if (_objectMover == null)
				{
					_objectMover = (CHandle<ObjectMoverComponent>) CR2WTypeManager.Create("handle:ObjectMoverComponent", "objectMover", cr2w, this);
				}
				return _objectMover;
			}
			set
			{
				if (_objectMover == value)
				{
					return;
				}
				_objectMover = value;
				PropertySet(this);
			}
		}

		public WallScreen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

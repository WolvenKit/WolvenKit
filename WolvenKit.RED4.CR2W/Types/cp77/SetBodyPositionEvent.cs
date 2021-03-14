using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetBodyPositionEvent : redEvent
	{
		private Vector4 _bodyPosition;
		private entEntityID _bodyPositionID;
		private CBool _pickedUp;

		[Ordinal(0)] 
		[RED("bodyPosition")] 
		public Vector4 BodyPosition
		{
			get
			{
				if (_bodyPosition == null)
				{
					_bodyPosition = (Vector4) CR2WTypeManager.Create("Vector4", "bodyPosition", cr2w, this);
				}
				return _bodyPosition;
			}
			set
			{
				if (_bodyPosition == value)
				{
					return;
				}
				_bodyPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("bodyPositionID")] 
		public entEntityID BodyPositionID
		{
			get
			{
				if (_bodyPositionID == null)
				{
					_bodyPositionID = (entEntityID) CR2WTypeManager.Create("entEntityID", "bodyPositionID", cr2w, this);
				}
				return _bodyPositionID;
			}
			set
			{
				if (_bodyPositionID == value)
				{
					return;
				}
				_bodyPositionID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("pickedUp")] 
		public CBool PickedUp
		{
			get
			{
				if (_pickedUp == null)
				{
					_pickedUp = (CBool) CR2WTypeManager.Create("Bool", "pickedUp", cr2w, this);
				}
				return _pickedUp;
			}
			set
			{
				if (_pickedUp == value)
				{
					return;
				}
				_pickedUp = value;
				PropertySet(this);
			}
		}

		public SetBodyPositionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

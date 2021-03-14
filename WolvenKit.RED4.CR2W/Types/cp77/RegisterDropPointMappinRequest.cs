using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterDropPointMappinRequest : gameScriptableSystemRequest
	{
		private entEntityID _ownerID;
		private Vector4 _position;
		private gameNewMappinID _trackingAlternativeMappinID;

		[Ordinal(0)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get
			{
				if (_ownerID == null)
				{
					_ownerID = (entEntityID) CR2WTypeManager.Create("entEntityID", "ownerID", cr2w, this);
				}
				return _ownerID;
			}
			set
			{
				if (_ownerID == value)
				{
					return;
				}
				_ownerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("trackingAlternativeMappinID")] 
		public gameNewMappinID TrackingAlternativeMappinID
		{
			get
			{
				if (_trackingAlternativeMappinID == null)
				{
					_trackingAlternativeMappinID = (gameNewMappinID) CR2WTypeManager.Create("gameNewMappinID", "trackingAlternativeMappinID", cr2w, this);
				}
				return _trackingAlternativeMappinID;
			}
			set
			{
				if (_trackingAlternativeMappinID == value)
				{
					return;
				}
				_trackingAlternativeMappinID = value;
				PropertySet(this);
			}
		}

		public RegisterDropPointMappinRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

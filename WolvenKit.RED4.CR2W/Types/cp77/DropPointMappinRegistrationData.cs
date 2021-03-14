using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropPointMappinRegistrationData : IScriptable
	{
		private entEntityID _ownerID;
		private Vector4 _position;
		private gameNewMappinID _mapinID;
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
		[RED("mapinID")] 
		public gameNewMappinID MapinID
		{
			get
			{
				if (_mapinID == null)
				{
					_mapinID = (gameNewMappinID) CR2WTypeManager.Create("gameNewMappinID", "mapinID", cr2w, this);
				}
				return _mapinID;
			}
			set
			{
				if (_mapinID == value)
				{
					return;
				}
				_mapinID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		public DropPointMappinRegistrationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

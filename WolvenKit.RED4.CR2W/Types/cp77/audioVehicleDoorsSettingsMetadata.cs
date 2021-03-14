using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleDoorsSettingsMetadata : CVariable
	{
		private audioVehicleDoorsSettings _door;
		private audioVehicleDoorsSettings _trunk;
		private audioVehicleDoorsSettings _hood;

		[Ordinal(0)] 
		[RED("door")] 
		public audioVehicleDoorsSettings Door
		{
			get
			{
				if (_door == null)
				{
					_door = (audioVehicleDoorsSettings) CR2WTypeManager.Create("audioVehicleDoorsSettings", "door", cr2w, this);
				}
				return _door;
			}
			set
			{
				if (_door == value)
				{
					return;
				}
				_door = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("trunk")] 
		public audioVehicleDoorsSettings Trunk
		{
			get
			{
				if (_trunk == null)
				{
					_trunk = (audioVehicleDoorsSettings) CR2WTypeManager.Create("audioVehicleDoorsSettings", "trunk", cr2w, this);
				}
				return _trunk;
			}
			set
			{
				if (_trunk == value)
				{
					return;
				}
				_trunk = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hood")] 
		public audioVehicleDoorsSettings Hood
		{
			get
			{
				if (_hood == null)
				{
					_hood = (audioVehicleDoorsSettings) CR2WTypeManager.Create("audioVehicleDoorsSettings", "hood", cr2w, this);
				}
				return _hood;
			}
			set
			{
				if (_hood == value)
				{
					return;
				}
				_hood = value;
				PropertySet(this);
			}
		}

		public audioVehicleDoorsSettingsMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeatureDoor : animAnimFeature
	{
		private CFloat _progress;
		private CFloat _openingSpeed;
		private CInt32 _openingType;
		private CInt32 _doorSide;

		[Ordinal(0)] 
		[RED("progress")] 
		public CFloat Progress
		{
			get
			{
				if (_progress == null)
				{
					_progress = (CFloat) CR2WTypeManager.Create("Float", "progress", cr2w, this);
				}
				return _progress;
			}
			set
			{
				if (_progress == value)
				{
					return;
				}
				_progress = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("openingSpeed")] 
		public CFloat OpeningSpeed
		{
			get
			{
				if (_openingSpeed == null)
				{
					_openingSpeed = (CFloat) CR2WTypeManager.Create("Float", "openingSpeed", cr2w, this);
				}
				return _openingSpeed;
			}
			set
			{
				if (_openingSpeed == value)
				{
					return;
				}
				_openingSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("openingType")] 
		public CInt32 OpeningType
		{
			get
			{
				if (_openingType == null)
				{
					_openingType = (CInt32) CR2WTypeManager.Create("Int32", "openingType", cr2w, this);
				}
				return _openingType;
			}
			set
			{
				if (_openingType == value)
				{
					return;
				}
				_openingType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("doorSide")] 
		public CInt32 DoorSide
		{
			get
			{
				if (_doorSide == null)
				{
					_doorSide = (CInt32) CR2WTypeManager.Create("Int32", "doorSide", cr2w, this);
				}
				return _doorSide;
			}
			set
			{
				if (_doorSide == value)
				{
					return;
				}
				_doorSide = value;
				PropertySet(this);
			}
		}

		public AnimFeatureDoor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioSoundComponentBase : entIPlacedComponent
	{
		private CName _audioName;
		private CBool _applyObstruction;
		private CBool _applyAcousticOcclusion;
		private CBool _applyAcousticRepositioning;
		private CFloat _obstructionChangeTime;
		private CFloat _maxPlayDistance;

		[Ordinal(5)] 
		[RED("audioName")] 
		public CName AudioName
		{
			get
			{
				if (_audioName == null)
				{
					_audioName = (CName) CR2WTypeManager.Create("CName", "audioName", cr2w, this);
				}
				return _audioName;
			}
			set
			{
				if (_audioName == value)
				{
					return;
				}
				_audioName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("applyObstruction")] 
		public CBool ApplyObstruction
		{
			get
			{
				if (_applyObstruction == null)
				{
					_applyObstruction = (CBool) CR2WTypeManager.Create("Bool", "applyObstruction", cr2w, this);
				}
				return _applyObstruction;
			}
			set
			{
				if (_applyObstruction == value)
				{
					return;
				}
				_applyObstruction = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("applyAcousticOcclusion")] 
		public CBool ApplyAcousticOcclusion
		{
			get
			{
				if (_applyAcousticOcclusion == null)
				{
					_applyAcousticOcclusion = (CBool) CR2WTypeManager.Create("Bool", "applyAcousticOcclusion", cr2w, this);
				}
				return _applyAcousticOcclusion;
			}
			set
			{
				if (_applyAcousticOcclusion == value)
				{
					return;
				}
				_applyAcousticOcclusion = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("applyAcousticRepositioning")] 
		public CBool ApplyAcousticRepositioning
		{
			get
			{
				if (_applyAcousticRepositioning == null)
				{
					_applyAcousticRepositioning = (CBool) CR2WTypeManager.Create("Bool", "applyAcousticRepositioning", cr2w, this);
				}
				return _applyAcousticRepositioning;
			}
			set
			{
				if (_applyAcousticRepositioning == value)
				{
					return;
				}
				_applyAcousticRepositioning = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("obstructionChangeTime")] 
		public CFloat ObstructionChangeTime
		{
			get
			{
				if (_obstructionChangeTime == null)
				{
					_obstructionChangeTime = (CFloat) CR2WTypeManager.Create("Float", "obstructionChangeTime", cr2w, this);
				}
				return _obstructionChangeTime;
			}
			set
			{
				if (_obstructionChangeTime == value)
				{
					return;
				}
				_obstructionChangeTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("maxPlayDistance")] 
		public CFloat MaxPlayDistance
		{
			get
			{
				if (_maxPlayDistance == null)
				{
					_maxPlayDistance = (CFloat) CR2WTypeManager.Create("Float", "maxPlayDistance", cr2w, this);
				}
				return _maxPlayDistance;
			}
			set
			{
				if (_maxPlayDistance == value)
				{
					return;
				}
				_maxPlayDistance = value;
				PropertySet(this);
			}
		}

		public gameaudioSoundComponentBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneVOInfo : CVariable
	{
		private CName _inVoTrigger;
		private CName _outVoTrigger;
		private CFloat _duration;
		private CUInt16 _id;

		[Ordinal(0)] 
		[RED("inVoTrigger")] 
		public CName InVoTrigger
		{
			get
			{
				if (_inVoTrigger == null)
				{
					_inVoTrigger = (CName) CR2WTypeManager.Create("CName", "inVoTrigger", cr2w, this);
				}
				return _inVoTrigger;
			}
			set
			{
				if (_inVoTrigger == value)
				{
					return;
				}
				_inVoTrigger = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("outVoTrigger")] 
		public CName OutVoTrigger
		{
			get
			{
				if (_outVoTrigger == null)
				{
					_outVoTrigger = (CName) CR2WTypeManager.Create("CName", "outVoTrigger", cr2w, this);
				}
				return _outVoTrigger;
			}
			set
			{
				if (_outVoTrigger == value)
				{
					return;
				}
				_outVoTrigger = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("id")] 
		public CUInt16 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CUInt16) CR2WTypeManager.Create("Uint16", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		public scnSceneVOInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

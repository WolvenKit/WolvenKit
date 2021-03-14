using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class redTaskProgressMessage : CVariable
	{
		private CUInt32 _id;
		private CFloat _progress;
		private CFloat _processingTime;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CUInt32) CR2WTypeManager.Create("Uint32", "id", cr2w, this);
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("processingTime")] 
		public CFloat ProcessingTime
		{
			get
			{
				if (_processingTime == null)
				{
					_processingTime = (CFloat) CR2WTypeManager.Create("Float", "processingTime", cr2w, this);
				}
				return _processingTime;
			}
			set
			{
				if (_processingTime == value)
				{
					return;
				}
				_processingTime = value;
				PropertySet(this);
			}
		}

		public redTaskProgressMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

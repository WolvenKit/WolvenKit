using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateMachineInstanceData : CVariable
	{
		private CName _referenceName;
		private CUInt32 _priority;
		private CHandle<IScriptable> _initData;

		[Ordinal(0)] 
		[RED("referenceName")] 
		public CName ReferenceName
		{
			get
			{
				if (_referenceName == null)
				{
					_referenceName = (CName) CR2WTypeManager.Create("CName", "referenceName", cr2w, this);
				}
				return _referenceName;
			}
			set
			{
				if (_referenceName == value)
				{
					return;
				}
				_referenceName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("priority")] 
		public CUInt32 Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CUInt32) CR2WTypeManager.Create("Uint32", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("initData")] 
		public CHandle<IScriptable> InitData
		{
			get
			{
				if (_initData == null)
				{
					_initData = (CHandle<IScriptable>) CR2WTypeManager.Create("handle:IScriptable", "initData", cr2w, this);
				}
				return _initData;
			}
			set
			{
				if (_initData == value)
				{
					return;
				}
				_initData = value;
				PropertySet(this);
			}
		}

		public gamestateMachineStateMachineInstanceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

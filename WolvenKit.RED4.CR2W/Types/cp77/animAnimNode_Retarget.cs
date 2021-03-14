using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Retarget : animAnimNode_OnePoseInput
	{
		private rRef<animRig> _refRig;
		private CHandle<animIAnimNode_PostProcess> _postProcess;

		[Ordinal(12)] 
		[RED("refRig")] 
		public rRef<animRig> RefRig
		{
			get
			{
				if (_refRig == null)
				{
					_refRig = (rRef<animRig>) CR2WTypeManager.Create("rRef:animRig", "refRig", cr2w, this);
				}
				return _refRig;
			}
			set
			{
				if (_refRig == value)
				{
					return;
				}
				_refRig = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("postProcess")] 
		public CHandle<animIAnimNode_PostProcess> PostProcess
		{
			get
			{
				if (_postProcess == null)
				{
					_postProcess = (CHandle<animIAnimNode_PostProcess>) CR2WTypeManager.Create("handle:animIAnimNode_PostProcess", "postProcess", cr2w, this);
				}
				return _postProcess;
			}
			set
			{
				if (_postProcess == value)
				{
					return;
				}
				_postProcess = value;
				PropertySet(this);
			}
		}

		public animAnimNode_Retarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

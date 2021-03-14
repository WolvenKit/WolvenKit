using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workWorkspotAnimsetEntry : CVariable
	{
		private raRef<animRig> _rig;
		private animAnimSetup _animations;
		private CArray<rRef<animAnimSet>> _loadingHandles;

		[Ordinal(0)] 
		[RED("rig")] 
		public raRef<animRig> Rig
		{
			get
			{
				if (_rig == null)
				{
					_rig = (raRef<animRig>) CR2WTypeManager.Create("raRef:animRig", "rig", cr2w, this);
				}
				return _rig;
			}
			set
			{
				if (_rig == value)
				{
					return;
				}
				_rig = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("animations")] 
		public animAnimSetup Animations
		{
			get
			{
				if (_animations == null)
				{
					_animations = (animAnimSetup) CR2WTypeManager.Create("animAnimSetup", "animations", cr2w, this);
				}
				return _animations;
			}
			set
			{
				if (_animations == value)
				{
					return;
				}
				_animations = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("loadingHandles")] 
		public CArray<rRef<animAnimSet>> LoadingHandles
		{
			get
			{
				if (_loadingHandles == null)
				{
					_loadingHandles = (CArray<rRef<animAnimSet>>) CR2WTypeManager.Create("array:rRef:animAnimSet", "loadingHandles", cr2w, this);
				}
				return _loadingHandles;
			}
			set
			{
				if (_loadingHandles == value)
				{
					return;
				}
				_loadingHandles = value;
				PropertySet(this);
			}
		}

		public workWorkspotAnimsetEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

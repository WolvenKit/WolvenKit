using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animFacialSetup_PosesBufferInfo : CVariable
	{
		private animFacialSetup_OneSermoPoseBufferInfo _face;
		private animFacialSetup_OneSermoPoseBufferInfo _tongue;
		private animFacialSetup_OneSermoPoseBufferInfo _eyes;

		[Ordinal(0)] 
		[RED("face")] 
		public animFacialSetup_OneSermoPoseBufferInfo Face
		{
			get
			{
				if (_face == null)
				{
					_face = (animFacialSetup_OneSermoPoseBufferInfo) CR2WTypeManager.Create("animFacialSetup_OneSermoPoseBufferInfo", "face", cr2w, this);
				}
				return _face;
			}
			set
			{
				if (_face == value)
				{
					return;
				}
				_face = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("tongue")] 
		public animFacialSetup_OneSermoPoseBufferInfo Tongue
		{
			get
			{
				if (_tongue == null)
				{
					_tongue = (animFacialSetup_OneSermoPoseBufferInfo) CR2WTypeManager.Create("animFacialSetup_OneSermoPoseBufferInfo", "tongue", cr2w, this);
				}
				return _tongue;
			}
			set
			{
				if (_tongue == value)
				{
					return;
				}
				_tongue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("eyes")] 
		public animFacialSetup_OneSermoPoseBufferInfo Eyes
		{
			get
			{
				if (_eyes == null)
				{
					_eyes = (animFacialSetup_OneSermoPoseBufferInfo) CR2WTypeManager.Create("animFacialSetup_OneSermoPoseBufferInfo", "eyes", cr2w, this);
				}
				return _eyes;
			}
			set
			{
				if (_eyes == value)
				{
					return;
				}
				_eyes = value;
				PropertySet(this);
			}
		}

		public animFacialSetup_PosesBufferInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

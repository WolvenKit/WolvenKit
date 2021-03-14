using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioRigMetadata : audioAudioMetadata
	{
		private CArray<CName> _positionBones;
		private CName _defaultBone;

		[Ordinal(1)] 
		[RED("positionBones")] 
		public CArray<CName> PositionBones
		{
			get
			{
				if (_positionBones == null)
				{
					_positionBones = (CArray<CName>) CR2WTypeManager.Create("array:CName", "positionBones", cr2w, this);
				}
				return _positionBones;
			}
			set
			{
				if (_positionBones == value)
				{
					return;
				}
				_positionBones = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("defaultBone")] 
		public CName DefaultBone
		{
			get
			{
				if (_defaultBone == null)
				{
					_defaultBone = (CName) CR2WTypeManager.Create("CName", "defaultBone", cr2w, this);
				}
				return _defaultBone;
			}
			set
			{
				if (_defaultBone == value)
				{
					return;
				}
				_defaultBone = value;
				PropertySet(this);
			}
		}

		public audioRigMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

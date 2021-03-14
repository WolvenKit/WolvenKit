using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsSpawnEntityEventCachedFallbackBone : CVariable
	{
		private CName _boneName;
		private Transform _modelSpaceTransform;

		[Ordinal(0)] 
		[RED("boneName")] 
		public CName BoneName
		{
			get
			{
				if (_boneName == null)
				{
					_boneName = (CName) CR2WTypeManager.Create("CName", "boneName", cr2w, this);
				}
				return _boneName;
			}
			set
			{
				if (_boneName == value)
				{
					return;
				}
				_boneName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("modelSpaceTransform")] 
		public Transform ModelSpaceTransform
		{
			get
			{
				if (_modelSpaceTransform == null)
				{
					_modelSpaceTransform = (Transform) CR2WTypeManager.Create("Transform", "modelSpaceTransform", cr2w, this);
				}
				return _modelSpaceTransform;
			}
			set
			{
				if (_modelSpaceTransform == value)
				{
					return;
				}
				_modelSpaceTransform = value;
				PropertySet(this);
			}
		}

		public scneventsSpawnEntityEventCachedFallbackBone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamesmartGunUISightParameters : CVariable
	{
		private Vector2 _center;
		private Vector2 _targetableRegionSize;
		private Vector2 _reticleSize;

		[Ordinal(0)] 
		[RED("center")] 
		public Vector2 Center
		{
			get
			{
				if (_center == null)
				{
					_center = (Vector2) CR2WTypeManager.Create("Vector2", "center", cr2w, this);
				}
				return _center;
			}
			set
			{
				if (_center == value)
				{
					return;
				}
				_center = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetableRegionSize")] 
		public Vector2 TargetableRegionSize
		{
			get
			{
				if (_targetableRegionSize == null)
				{
					_targetableRegionSize = (Vector2) CR2WTypeManager.Create("Vector2", "targetableRegionSize", cr2w, this);
				}
				return _targetableRegionSize;
			}
			set
			{
				if (_targetableRegionSize == value)
				{
					return;
				}
				_targetableRegionSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("reticleSize")] 
		public Vector2 ReticleSize
		{
			get
			{
				if (_reticleSize == null)
				{
					_reticleSize = (Vector2) CR2WTypeManager.Create("Vector2", "reticleSize", cr2w, this);
				}
				return _reticleSize;
			}
			set
			{
				if (_reticleSize == value)
				{
					return;
				}
				_reticleSize = value;
				PropertySet(this);
			}
		}

		public gamesmartGunUISightParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

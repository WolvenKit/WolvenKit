using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FilmGrainAreaSettings : IAreaSettings
	{
		private curveData<Vector4> _strength;
		private curveData<CFloat> _luminanceBias;
		private Vector3 _grainSize;
		private CBool _applyAfterUpsampling;

		[Ordinal(2)] 
		[RED("strength")] 
		public curveData<Vector4> Strength
		{
			get
			{
				if (_strength == null)
				{
					_strength = (curveData<Vector4>) CR2WTypeManager.Create("curveData:Vector4", "strength", cr2w, this);
				}
				return _strength;
			}
			set
			{
				if (_strength == value)
				{
					return;
				}
				_strength = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("luminanceBias")] 
		public curveData<CFloat> LuminanceBias
		{
			get
			{
				if (_luminanceBias == null)
				{
					_luminanceBias = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "luminanceBias", cr2w, this);
				}
				return _luminanceBias;
			}
			set
			{
				if (_luminanceBias == value)
				{
					return;
				}
				_luminanceBias = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("grainSize")] 
		public Vector3 GrainSize
		{
			get
			{
				if (_grainSize == null)
				{
					_grainSize = (Vector3) CR2WTypeManager.Create("Vector3", "grainSize", cr2w, this);
				}
				return _grainSize;
			}
			set
			{
				if (_grainSize == value)
				{
					return;
				}
				_grainSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("applyAfterUpsampling")] 
		public CBool ApplyAfterUpsampling
		{
			get
			{
				if (_applyAfterUpsampling == null)
				{
					_applyAfterUpsampling = (CBool) CR2WTypeManager.Create("Bool", "applyAfterUpsampling", cr2w, this);
				}
				return _applyAfterUpsampling;
			}
			set
			{
				if (_applyAfterUpsampling == value)
				{
					return;
				}
				_applyAfterUpsampling = value;
				PropertySet(this);
			}
		}

		public FilmGrainAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SSAOAreaSettings : IAreaSettings
	{
		private curveData<CFloat> _noiseFilterTolerance;
		private curveData<CFloat> _blurTolerance;
		private curveData<CFloat> _upsampleTolerance;
		private curveData<CFloat> _rejectionFalloff;
		private CBool _combineResolutionsBeforeBlur;
		private CBool _combineResolutionsWithMul;
		private CBool _normalsEnable;
		private CInt32 _hierarchyDepth;
		private curveData<CFloat> _normalAOMultiply;
		private curveData<CFloat> _normalBackProjectTolerance;
		private CEnum<ESSAOQualityLevel> _qualityLevel;
		private curveData<CFloat> _coneAoDiffuseStrength;
		private curveData<CFloat> _coneAoSpecularStrength;
		private curveData<CFloat> _coneAoSpecularTreshold;
		private curveData<CFloat> _lightAoDiffuseStrength;
		private curveData<CFloat> _lightAoSpecularStrength;
		private curveData<CFloat> _foliageDimDiffuse;
		private curveData<CFloat> _foliageDimSpecular;

		[Ordinal(2)] 
		[RED("noiseFilterTolerance")] 
		public curveData<CFloat> NoiseFilterTolerance
		{
			get
			{
				if (_noiseFilterTolerance == null)
				{
					_noiseFilterTolerance = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "noiseFilterTolerance", cr2w, this);
				}
				return _noiseFilterTolerance;
			}
			set
			{
				if (_noiseFilterTolerance == value)
				{
					return;
				}
				_noiseFilterTolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("blurTolerance")] 
		public curveData<CFloat> BlurTolerance
		{
			get
			{
				if (_blurTolerance == null)
				{
					_blurTolerance = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "blurTolerance", cr2w, this);
				}
				return _blurTolerance;
			}
			set
			{
				if (_blurTolerance == value)
				{
					return;
				}
				_blurTolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("upsampleTolerance")] 
		public curveData<CFloat> UpsampleTolerance
		{
			get
			{
				if (_upsampleTolerance == null)
				{
					_upsampleTolerance = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "upsampleTolerance", cr2w, this);
				}
				return _upsampleTolerance;
			}
			set
			{
				if (_upsampleTolerance == value)
				{
					return;
				}
				_upsampleTolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("rejectionFalloff")] 
		public curveData<CFloat> RejectionFalloff
		{
			get
			{
				if (_rejectionFalloff == null)
				{
					_rejectionFalloff = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "rejectionFalloff", cr2w, this);
				}
				return _rejectionFalloff;
			}
			set
			{
				if (_rejectionFalloff == value)
				{
					return;
				}
				_rejectionFalloff = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("combineResolutionsBeforeBlur")] 
		public CBool CombineResolutionsBeforeBlur
		{
			get
			{
				if (_combineResolutionsBeforeBlur == null)
				{
					_combineResolutionsBeforeBlur = (CBool) CR2WTypeManager.Create("Bool", "combineResolutionsBeforeBlur", cr2w, this);
				}
				return _combineResolutionsBeforeBlur;
			}
			set
			{
				if (_combineResolutionsBeforeBlur == value)
				{
					return;
				}
				_combineResolutionsBeforeBlur = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("combineResolutionsWithMul")] 
		public CBool CombineResolutionsWithMul
		{
			get
			{
				if (_combineResolutionsWithMul == null)
				{
					_combineResolutionsWithMul = (CBool) CR2WTypeManager.Create("Bool", "combineResolutionsWithMul", cr2w, this);
				}
				return _combineResolutionsWithMul;
			}
			set
			{
				if (_combineResolutionsWithMul == value)
				{
					return;
				}
				_combineResolutionsWithMul = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("normalsEnable")] 
		public CBool NormalsEnable
		{
			get
			{
				if (_normalsEnable == null)
				{
					_normalsEnable = (CBool) CR2WTypeManager.Create("Bool", "normalsEnable", cr2w, this);
				}
				return _normalsEnable;
			}
			set
			{
				if (_normalsEnable == value)
				{
					return;
				}
				_normalsEnable = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("hierarchyDepth")] 
		public CInt32 HierarchyDepth
		{
			get
			{
				if (_hierarchyDepth == null)
				{
					_hierarchyDepth = (CInt32) CR2WTypeManager.Create("Int32", "hierarchyDepth", cr2w, this);
				}
				return _hierarchyDepth;
			}
			set
			{
				if (_hierarchyDepth == value)
				{
					return;
				}
				_hierarchyDepth = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("normalAOMultiply")] 
		public curveData<CFloat> NormalAOMultiply
		{
			get
			{
				if (_normalAOMultiply == null)
				{
					_normalAOMultiply = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "normalAOMultiply", cr2w, this);
				}
				return _normalAOMultiply;
			}
			set
			{
				if (_normalAOMultiply == value)
				{
					return;
				}
				_normalAOMultiply = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("normalBackProjectTolerance")] 
		public curveData<CFloat> NormalBackProjectTolerance
		{
			get
			{
				if (_normalBackProjectTolerance == null)
				{
					_normalBackProjectTolerance = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "normalBackProjectTolerance", cr2w, this);
				}
				return _normalBackProjectTolerance;
			}
			set
			{
				if (_normalBackProjectTolerance == value)
				{
					return;
				}
				_normalBackProjectTolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("qualityLevel")] 
		public CEnum<ESSAOQualityLevel> QualityLevel
		{
			get
			{
				if (_qualityLevel == null)
				{
					_qualityLevel = (CEnum<ESSAOQualityLevel>) CR2WTypeManager.Create("ESSAOQualityLevel", "qualityLevel", cr2w, this);
				}
				return _qualityLevel;
			}
			set
			{
				if (_qualityLevel == value)
				{
					return;
				}
				_qualityLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("coneAoDiffuseStrength")] 
		public curveData<CFloat> ConeAoDiffuseStrength
		{
			get
			{
				if (_coneAoDiffuseStrength == null)
				{
					_coneAoDiffuseStrength = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "coneAoDiffuseStrength", cr2w, this);
				}
				return _coneAoDiffuseStrength;
			}
			set
			{
				if (_coneAoDiffuseStrength == value)
				{
					return;
				}
				_coneAoDiffuseStrength = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("coneAoSpecularStrength")] 
		public curveData<CFloat> ConeAoSpecularStrength
		{
			get
			{
				if (_coneAoSpecularStrength == null)
				{
					_coneAoSpecularStrength = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "coneAoSpecularStrength", cr2w, this);
				}
				return _coneAoSpecularStrength;
			}
			set
			{
				if (_coneAoSpecularStrength == value)
				{
					return;
				}
				_coneAoSpecularStrength = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("coneAoSpecularTreshold")] 
		public curveData<CFloat> ConeAoSpecularTreshold
		{
			get
			{
				if (_coneAoSpecularTreshold == null)
				{
					_coneAoSpecularTreshold = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "coneAoSpecularTreshold", cr2w, this);
				}
				return _coneAoSpecularTreshold;
			}
			set
			{
				if (_coneAoSpecularTreshold == value)
				{
					return;
				}
				_coneAoSpecularTreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("lightAoDiffuseStrength")] 
		public curveData<CFloat> LightAoDiffuseStrength
		{
			get
			{
				if (_lightAoDiffuseStrength == null)
				{
					_lightAoDiffuseStrength = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "lightAoDiffuseStrength", cr2w, this);
				}
				return _lightAoDiffuseStrength;
			}
			set
			{
				if (_lightAoDiffuseStrength == value)
				{
					return;
				}
				_lightAoDiffuseStrength = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("lightAoSpecularStrength")] 
		public curveData<CFloat> LightAoSpecularStrength
		{
			get
			{
				if (_lightAoSpecularStrength == null)
				{
					_lightAoSpecularStrength = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "lightAoSpecularStrength", cr2w, this);
				}
				return _lightAoSpecularStrength;
			}
			set
			{
				if (_lightAoSpecularStrength == value)
				{
					return;
				}
				_lightAoSpecularStrength = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("foliageDimDiffuse")] 
		public curveData<CFloat> FoliageDimDiffuse
		{
			get
			{
				if (_foliageDimDiffuse == null)
				{
					_foliageDimDiffuse = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "foliageDimDiffuse", cr2w, this);
				}
				return _foliageDimDiffuse;
			}
			set
			{
				if (_foliageDimDiffuse == value)
				{
					return;
				}
				_foliageDimDiffuse = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("foliageDimSpecular")] 
		public curveData<CFloat> FoliageDimSpecular
		{
			get
			{
				if (_foliageDimSpecular == null)
				{
					_foliageDimSpecular = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "foliageDimSpecular", cr2w, this);
				}
				return _foliageDimSpecular;
			}
			set
			{
				if (_foliageDimSpecular == value)
				{
					return;
				}
				_foliageDimSpecular = value;
				PropertySet(this);
			}
		}

		public SSAOAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

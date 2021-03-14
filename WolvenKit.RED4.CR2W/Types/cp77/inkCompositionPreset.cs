using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCompositionPreset : CVariable
	{
		private CName _stateName;
		private CBool _useBackgroundTexture;
		private fxCompositionShaderParams _shaderParams;
		private CArray<inkCompositionTransition> _transitions;

		[Ordinal(0)] 
		[RED("stateName")] 
		public CName StateName
		{
			get
			{
				if (_stateName == null)
				{
					_stateName = (CName) CR2WTypeManager.Create("CName", "stateName", cr2w, this);
				}
				return _stateName;
			}
			set
			{
				if (_stateName == value)
				{
					return;
				}
				_stateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("useBackgroundTexture")] 
		public CBool UseBackgroundTexture
		{
			get
			{
				if (_useBackgroundTexture == null)
				{
					_useBackgroundTexture = (CBool) CR2WTypeManager.Create("Bool", "useBackgroundTexture", cr2w, this);
				}
				return _useBackgroundTexture;
			}
			set
			{
				if (_useBackgroundTexture == value)
				{
					return;
				}
				_useBackgroundTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("shaderParams")] 
		public fxCompositionShaderParams ShaderParams
		{
			get
			{
				if (_shaderParams == null)
				{
					_shaderParams = (fxCompositionShaderParams) CR2WTypeManager.Create("fxCompositionShaderParams", "shaderParams", cr2w, this);
				}
				return _shaderParams;
			}
			set
			{
				if (_shaderParams == value)
				{
					return;
				}
				_shaderParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("transitions")] 
		public CArray<inkCompositionTransition> Transitions
		{
			get
			{
				if (_transitions == null)
				{
					_transitions = (CArray<inkCompositionTransition>) CR2WTypeManager.Create("array:inkCompositionTransition", "transitions", cr2w, this);
				}
				return _transitions;
			}
			set
			{
				if (_transitions == value)
				{
					return;
				}
				_transitions = value;
				PropertySet(this);
			}
		}

		public inkCompositionPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

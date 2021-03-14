using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PSODescRasterizerModeDesc : CVariable
	{
		private CBool _wireframe;
		private CEnum<PSODescRasterizerModeFrontFaceWinding> _frontWinding;
		private CEnum<PSODescRasterizerModeCullMode> _cullMode;
		private CBool _allowMSAA;
		private CBool _conservativeRasterization;
		private CEnum<PSODescRasterizerModeOffsetMode> _offsetMode;
		private CBool _scissors;
		private CBool _valid;

		[Ordinal(0)] 
		[RED("wireframe")] 
		public CBool Wireframe
		{
			get
			{
				if (_wireframe == null)
				{
					_wireframe = (CBool) CR2WTypeManager.Create("Bool", "wireframe", cr2w, this);
				}
				return _wireframe;
			}
			set
			{
				if (_wireframe == value)
				{
					return;
				}
				_wireframe = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("frontWinding")] 
		public CEnum<PSODescRasterizerModeFrontFaceWinding> FrontWinding
		{
			get
			{
				if (_frontWinding == null)
				{
					_frontWinding = (CEnum<PSODescRasterizerModeFrontFaceWinding>) CR2WTypeManager.Create("PSODescRasterizerModeFrontFaceWinding", "frontWinding", cr2w, this);
				}
				return _frontWinding;
			}
			set
			{
				if (_frontWinding == value)
				{
					return;
				}
				_frontWinding = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("cullMode")] 
		public CEnum<PSODescRasterizerModeCullMode> CullMode
		{
			get
			{
				if (_cullMode == null)
				{
					_cullMode = (CEnum<PSODescRasterizerModeCullMode>) CR2WTypeManager.Create("PSODescRasterizerModeCullMode", "cullMode", cr2w, this);
				}
				return _cullMode;
			}
			set
			{
				if (_cullMode == value)
				{
					return;
				}
				_cullMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("allowMSAA")] 
		public CBool AllowMSAA
		{
			get
			{
				if (_allowMSAA == null)
				{
					_allowMSAA = (CBool) CR2WTypeManager.Create("Bool", "allowMSAA", cr2w, this);
				}
				return _allowMSAA;
			}
			set
			{
				if (_allowMSAA == value)
				{
					return;
				}
				_allowMSAA = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("conservativeRasterization")] 
		public CBool ConservativeRasterization
		{
			get
			{
				if (_conservativeRasterization == null)
				{
					_conservativeRasterization = (CBool) CR2WTypeManager.Create("Bool", "conservativeRasterization", cr2w, this);
				}
				return _conservativeRasterization;
			}
			set
			{
				if (_conservativeRasterization == value)
				{
					return;
				}
				_conservativeRasterization = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("offsetMode")] 
		public CEnum<PSODescRasterizerModeOffsetMode> OffsetMode
		{
			get
			{
				if (_offsetMode == null)
				{
					_offsetMode = (CEnum<PSODescRasterizerModeOffsetMode>) CR2WTypeManager.Create("PSODescRasterizerModeOffsetMode", "offsetMode", cr2w, this);
				}
				return _offsetMode;
			}
			set
			{
				if (_offsetMode == value)
				{
					return;
				}
				_offsetMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("scissors")] 
		public CBool Scissors
		{
			get
			{
				if (_scissors == null)
				{
					_scissors = (CBool) CR2WTypeManager.Create("Bool", "scissors", cr2w, this);
				}
				return _scissors;
			}
			set
			{
				if (_scissors == value)
				{
					return;
				}
				_scissors = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("valid")] 
		public CBool Valid
		{
			get
			{
				if (_valid == null)
				{
					_valid = (CBool) CR2WTypeManager.Create("Bool", "valid", cr2w, this);
				}
				return _valid;
			}
			set
			{
				if (_valid == value)
				{
					return;
				}
				_valid = value;
				PropertySet(this);
			}
		}

		public PSODescRasterizerModeDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

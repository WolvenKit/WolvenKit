using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entRenderToTextureFeatures : CVariable
	{
		private CBool _renderDecals;
		private CBool _renderParticles;
		private CBool _renderForwardNoTXAA;
		private CBool _antiAliasing;
		private CBool _contactShadows;
		private CBool _localShadows;
		private CBool _allowOcclusionCulling;

		[Ordinal(0)] 
		[RED("renderDecals")] 
		public CBool RenderDecals
		{
			get
			{
				if (_renderDecals == null)
				{
					_renderDecals = (CBool) CR2WTypeManager.Create("Bool", "renderDecals", cr2w, this);
				}
				return _renderDecals;
			}
			set
			{
				if (_renderDecals == value)
				{
					return;
				}
				_renderDecals = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("renderParticles")] 
		public CBool RenderParticles
		{
			get
			{
				if (_renderParticles == null)
				{
					_renderParticles = (CBool) CR2WTypeManager.Create("Bool", "renderParticles", cr2w, this);
				}
				return _renderParticles;
			}
			set
			{
				if (_renderParticles == value)
				{
					return;
				}
				_renderParticles = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("renderForwardNoTXAA")] 
		public CBool RenderForwardNoTXAA
		{
			get
			{
				if (_renderForwardNoTXAA == null)
				{
					_renderForwardNoTXAA = (CBool) CR2WTypeManager.Create("Bool", "renderForwardNoTXAA", cr2w, this);
				}
				return _renderForwardNoTXAA;
			}
			set
			{
				if (_renderForwardNoTXAA == value)
				{
					return;
				}
				_renderForwardNoTXAA = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("antiAliasing")] 
		public CBool AntiAliasing
		{
			get
			{
				if (_antiAliasing == null)
				{
					_antiAliasing = (CBool) CR2WTypeManager.Create("Bool", "antiAliasing", cr2w, this);
				}
				return _antiAliasing;
			}
			set
			{
				if (_antiAliasing == value)
				{
					return;
				}
				_antiAliasing = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("contactShadows")] 
		public CBool ContactShadows
		{
			get
			{
				if (_contactShadows == null)
				{
					_contactShadows = (CBool) CR2WTypeManager.Create("Bool", "contactShadows", cr2w, this);
				}
				return _contactShadows;
			}
			set
			{
				if (_contactShadows == value)
				{
					return;
				}
				_contactShadows = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("localShadows")] 
		public CBool LocalShadows
		{
			get
			{
				if (_localShadows == null)
				{
					_localShadows = (CBool) CR2WTypeManager.Create("Bool", "localShadows", cr2w, this);
				}
				return _localShadows;
			}
			set
			{
				if (_localShadows == value)
				{
					return;
				}
				_localShadows = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("allowOcclusionCulling")] 
		public CBool AllowOcclusionCulling
		{
			get
			{
				if (_allowOcclusionCulling == null)
				{
					_allowOcclusionCulling = (CBool) CR2WTypeManager.Create("Bool", "allowOcclusionCulling", cr2w, this);
				}
				return _allowOcclusionCulling;
			}
			set
			{
				if (_allowOcclusionCulling == value)
				{
					return;
				}
				_allowOcclusionCulling = value;
				PropertySet(this);
			}
		}

		public entRenderToTextureFeatures(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

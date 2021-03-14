using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshChunkFlags : CVariable
	{
		private CBool _renderInScene;
		private CBool _renderInShadows;
		private CBool _isTwoSided;
		private CBool _isRayTracedEmissive;

		[Ordinal(0)] 
		[RED("renderInScene")] 
		public CBool RenderInScene
		{
			get
			{
				if (_renderInScene == null)
				{
					_renderInScene = (CBool) CR2WTypeManager.Create("Bool", "renderInScene", cr2w, this);
				}
				return _renderInScene;
			}
			set
			{
				if (_renderInScene == value)
				{
					return;
				}
				_renderInScene = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("renderInShadows")] 
		public CBool RenderInShadows
		{
			get
			{
				if (_renderInShadows == null)
				{
					_renderInShadows = (CBool) CR2WTypeManager.Create("Bool", "renderInShadows", cr2w, this);
				}
				return _renderInShadows;
			}
			set
			{
				if (_renderInShadows == value)
				{
					return;
				}
				_renderInShadows = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isTwoSided")] 
		public CBool IsTwoSided
		{
			get
			{
				if (_isTwoSided == null)
				{
					_isTwoSided = (CBool) CR2WTypeManager.Create("Bool", "isTwoSided", cr2w, this);
				}
				return _isTwoSided;
			}
			set
			{
				if (_isTwoSided == value)
				{
					return;
				}
				_isTwoSided = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isRayTracedEmissive")] 
		public CBool IsRayTracedEmissive
		{
			get
			{
				if (_isRayTracedEmissive == null)
				{
					_isRayTracedEmissive = (CBool) CR2WTypeManager.Create("Bool", "isRayTracedEmissive", cr2w, this);
				}
				return _isRayTracedEmissive;
			}
			set
			{
				if (_isRayTracedEmissive == value)
				{
					return;
				}
				_isRayTracedEmissive = value;
				PropertySet(this);
			}
		}

		public meshChunkFlags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

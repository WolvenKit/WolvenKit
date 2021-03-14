using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entRenderHighlightEvent : redEvent
	{
		private CUInt8 _fillIndex;
		private CUInt8 _outlineIndex;
		private CBool _seeThroughWalls;
		private CName _componentName;
		private CFloat _opacity;

		[Ordinal(0)] 
		[RED("fillIndex")] 
		public CUInt8 FillIndex
		{
			get
			{
				if (_fillIndex == null)
				{
					_fillIndex = (CUInt8) CR2WTypeManager.Create("Uint8", "fillIndex", cr2w, this);
				}
				return _fillIndex;
			}
			set
			{
				if (_fillIndex == value)
				{
					return;
				}
				_fillIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("outlineIndex")] 
		public CUInt8 OutlineIndex
		{
			get
			{
				if (_outlineIndex == null)
				{
					_outlineIndex = (CUInt8) CR2WTypeManager.Create("Uint8", "outlineIndex", cr2w, this);
				}
				return _outlineIndex;
			}
			set
			{
				if (_outlineIndex == value)
				{
					return;
				}
				_outlineIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("seeThroughWalls")] 
		public CBool SeeThroughWalls
		{
			get
			{
				if (_seeThroughWalls == null)
				{
					_seeThroughWalls = (CBool) CR2WTypeManager.Create("Bool", "seeThroughWalls", cr2w, this);
				}
				return _seeThroughWalls;
			}
			set
			{
				if (_seeThroughWalls == value)
				{
					return;
				}
				_seeThroughWalls = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get
			{
				if (_componentName == null)
				{
					_componentName = (CName) CR2WTypeManager.Create("CName", "componentName", cr2w, this);
				}
				return _componentName;
			}
			set
			{
				if (_componentName == value)
				{
					return;
				}
				_componentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get
			{
				if (_opacity == null)
				{
					_opacity = (CFloat) CR2WTypeManager.Create("Float", "opacity", cr2w, this);
				}
				return _opacity;
			}
			set
			{
				if (_opacity == value)
				{
					return;
				}
				_opacity = value;
				PropertySet(this);
			}
		}

		public entRenderHighlightEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

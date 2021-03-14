using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimapDataNode : worldNode
	{
		private raRef<minimapEncodedShapes> _encodedShapesRef;
		private Box _localBounds;
		private CBool _allInteriorShapes;

		[Ordinal(4)] 
		[RED("encodedShapesRef")] 
		public raRef<minimapEncodedShapes> EncodedShapesRef
		{
			get
			{
				if (_encodedShapesRef == null)
				{
					_encodedShapesRef = (raRef<minimapEncodedShapes>) CR2WTypeManager.Create("raRef:minimapEncodedShapes", "encodedShapesRef", cr2w, this);
				}
				return _encodedShapesRef;
			}
			set
			{
				if (_encodedShapesRef == value)
				{
					return;
				}
				_encodedShapesRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("localBounds")] 
		public Box LocalBounds
		{
			get
			{
				if (_localBounds == null)
				{
					_localBounds = (Box) CR2WTypeManager.Create("Box", "localBounds", cr2w, this);
				}
				return _localBounds;
			}
			set
			{
				if (_localBounds == value)
				{
					return;
				}
				_localBounds = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("allInteriorShapes")] 
		public CBool AllInteriorShapes
		{
			get
			{
				if (_allInteriorShapes == null)
				{
					_allInteriorShapes = (CBool) CR2WTypeManager.Create("Bool", "allInteriorShapes", cr2w, this);
				}
				return _allInteriorShapes;
			}
			set
			{
				if (_allInteriorShapes == value)
				{
					return;
				}
				_allInteriorShapes = value;
				PropertySet(this);
			}
		}

		public MinimapDataNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

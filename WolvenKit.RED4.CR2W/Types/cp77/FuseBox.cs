using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FuseBox : InteractiveMasterDevice
	{
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;
		private CInt32 _numberOfComponentsToON;
		private CInt32 _numberOfComponentsToOFF;
		private CArray<CInt32> _indexesOfComponentsToOFF;
		private CHandle<entMeshComponent> _mesh;
		private CArray<CHandle<entIPlacedComponent>> _componentsON;
		private CArray<CHandle<entIPlacedComponent>> _componentsOFF;

		[Ordinal(93)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get
			{
				if (_isShortGlitchActive == null)
				{
					_isShortGlitchActive = (CBool) CR2WTypeManager.Create("Bool", "isShortGlitchActive", cr2w, this);
				}
				return _isShortGlitchActive;
			}
			set
			{
				if (_isShortGlitchActive == value)
				{
					return;
				}
				_isShortGlitchActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get
			{
				if (_shortGlitchDelayID == null)
				{
					_shortGlitchDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "shortGlitchDelayID", cr2w, this);
				}
				return _shortGlitchDelayID;
			}
			set
			{
				if (_shortGlitchDelayID == value)
				{
					return;
				}
				_shortGlitchDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("numberOfComponentsToON")] 
		public CInt32 NumberOfComponentsToON
		{
			get
			{
				if (_numberOfComponentsToON == null)
				{
					_numberOfComponentsToON = (CInt32) CR2WTypeManager.Create("Int32", "numberOfComponentsToON", cr2w, this);
				}
				return _numberOfComponentsToON;
			}
			set
			{
				if (_numberOfComponentsToON == value)
				{
					return;
				}
				_numberOfComponentsToON = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("numberOfComponentsToOFF")] 
		public CInt32 NumberOfComponentsToOFF
		{
			get
			{
				if (_numberOfComponentsToOFF == null)
				{
					_numberOfComponentsToOFF = (CInt32) CR2WTypeManager.Create("Int32", "numberOfComponentsToOFF", cr2w, this);
				}
				return _numberOfComponentsToOFF;
			}
			set
			{
				if (_numberOfComponentsToOFF == value)
				{
					return;
				}
				_numberOfComponentsToOFF = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("indexesOfComponentsToOFF")] 
		public CArray<CInt32> IndexesOfComponentsToOFF
		{
			get
			{
				if (_indexesOfComponentsToOFF == null)
				{
					_indexesOfComponentsToOFF = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "indexesOfComponentsToOFF", cr2w, this);
				}
				return _indexesOfComponentsToOFF;
			}
			set
			{
				if (_indexesOfComponentsToOFF == value)
				{
					return;
				}
				_indexesOfComponentsToOFF = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
		[RED("mesh")] 
		public CHandle<entMeshComponent> Mesh
		{
			get
			{
				if (_mesh == null)
				{
					_mesh = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "mesh", cr2w, this);
				}
				return _mesh;
			}
			set
			{
				if (_mesh == value)
				{
					return;
				}
				_mesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(99)] 
		[RED("componentsON")] 
		public CArray<CHandle<entIPlacedComponent>> ComponentsON
		{
			get
			{
				if (_componentsON == null)
				{
					_componentsON = (CArray<CHandle<entIPlacedComponent>>) CR2WTypeManager.Create("array:handle:entIPlacedComponent", "componentsON", cr2w, this);
				}
				return _componentsON;
			}
			set
			{
				if (_componentsON == value)
				{
					return;
				}
				_componentsON = value;
				PropertySet(this);
			}
		}

		[Ordinal(100)] 
		[RED("componentsOFF")] 
		public CArray<CHandle<entIPlacedComponent>> ComponentsOFF
		{
			get
			{
				if (_componentsOFF == null)
				{
					_componentsOFF = (CArray<CHandle<entIPlacedComponent>>) CR2WTypeManager.Create("array:handle:entIPlacedComponent", "componentsOFF", cr2w, this);
				}
				return _componentsOFF;
			}
			set
			{
				if (_componentsOFF == value)
				{
					return;
				}
				_componentsOFF = value;
				PropertySet(this);
			}
		}

		public FuseBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

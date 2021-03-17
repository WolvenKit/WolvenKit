using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneMarkerInternalsEntry : CVariable
	{
		private scnSceneEventId _eventId;
		private CName _startName;
		private CName _endName;
		private CName _startDisplayName;
		private CName _endDisplayName;
		private Vector4 _startPos;
		private Vector4 _endPos;
		private Vector4 _startDir;
		private Vector4 _endDir;
		private CUInt8 _flags;

		[Ordinal(0)] 
		[RED("eventId")] 
		public scnSceneEventId EventId
		{
			get => GetProperty(ref _eventId);
			set => SetProperty(ref _eventId, value);
		}

		[Ordinal(1)] 
		[RED("startName")] 
		public CName StartName
		{
			get => GetProperty(ref _startName);
			set => SetProperty(ref _startName, value);
		}

		[Ordinal(2)] 
		[RED("endName")] 
		public CName EndName
		{
			get => GetProperty(ref _endName);
			set => SetProperty(ref _endName, value);
		}

		[Ordinal(3)] 
		[RED("startDisplayName")] 
		public CName StartDisplayName
		{
			get => GetProperty(ref _startDisplayName);
			set => SetProperty(ref _startDisplayName, value);
		}

		[Ordinal(4)] 
		[RED("endDisplayName")] 
		public CName EndDisplayName
		{
			get => GetProperty(ref _endDisplayName);
			set => SetProperty(ref _endDisplayName, value);
		}

		[Ordinal(5)] 
		[RED("startPos")] 
		public Vector4 StartPos
		{
			get => GetProperty(ref _startPos);
			set => SetProperty(ref _startPos, value);
		}

		[Ordinal(6)] 
		[RED("endPos")] 
		public Vector4 EndPos
		{
			get => GetProperty(ref _endPos);
			set => SetProperty(ref _endPos, value);
		}

		[Ordinal(7)] 
		[RED("startDir")] 
		public Vector4 StartDir
		{
			get => GetProperty(ref _startDir);
			set => SetProperty(ref _startDir, value);
		}

		[Ordinal(8)] 
		[RED("endDir")] 
		public Vector4 EndDir
		{
			get => GetProperty(ref _endDir);
			set => SetProperty(ref _endDir, value);
		}

		[Ordinal(9)] 
		[RED("flags")] 
		public CUInt8 Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}

		public scnSceneMarkerInternalsEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

// Copyright (C) 2014 Lauri Kasanen
// This file is part of the "Irrlicht Engine". The UTF-8 functions are from physfs,
// under the zlib license, reproduced below.

#include "irrTypes.h"
#include "irrString.h"

namespace irr
{
namespace core
{

/*
   Copyright (c) 2001-2011 Ryan C. Gordon and others.

   This software is provided 'as-is', without any express or implied warranty.
   In no event will the authors be held liable for any damages arising from
   the use of this software.

   Permission is granted to anyone to use this software for any purpose,
   including commercial applications, and to alter it and redistribute it
   freely, subject to the following restrictions:

   1. The origin of this software must not be misrepresented; you must not
   claim that you wrote the original software. If you use this software in a
   product, an acknowledgment in the product documentation would be
   appreciated but is not required.

   2. Altered source versions must be plainly marked as such, and must not be
   misrepresented as being the original software.

   3. This notice may not be removed or altered from any source distribution.

	   Ryan C. Gordon <icculus@icculus.org>
*/

/*
 * From rfc3629, the UTF-8 spec:
 *	http://www.ietf.org/rfc/rfc3629.txt
 *
 *	 Char. number range  |		  UTF-8 octet sequence
 *		(hexadecimal)	 |				(binary)
 *	 --------------------+---------------------------------------------
 *	 0000 0000-0000 007F | 0xxxxxxx
 *	 0000 0080-0000 07FF | 110xxxxx 10xxxxxx
 *	 0000 0800-0000 FFFF | 1110xxxx 10xxxxxx 10xxxxxx
 *	 0001 0000-0010 FFFF | 11110xxx 10xxxxxx 10xxxxxx 10xxxxxx
 */


/*
 * This may not be the best value, but it's one that isn't represented
 *	in Unicode (0x10FFFF is the largest codepoint value). We return this
 *	value from utf8codepoint() if there's bogus bits in the
 *	stream. utf8codepoint() will turn this value into something
 *	reasonable (like a question mark), for text that wants to try to recover,
 *	whereas utf8valid() will use the value to determine if a string has bad
 *	bits.
 */
#define UNICODE_BOGUS_CHAR_VALUE 0xFFFFFFFF

/*
 * This is the codepoint we currently return when there was bogus bits in a
 *	UTF-8 string. May not fly in Asian locales?
 */
#define UNICODE_BOGUS_CHAR_CODEPOINT '?'

static u32 utf8codepoint(const char **_str)
{
	const char *str = *_str;
	u32 retval = 0;
	u32 octet = (u32) ((u8) *str);
	u32 octet2, octet3, octet4;

	if (octet == 0)  /* null terminator, end of string. */
		return 0;

	else if (octet < 128)  /* one octet char: 0 to 127 */
	{
		(*_str)++;	/* skip to next possible start of codepoint. */
		return(octet);
	} /* else if */

	else if ((octet > 127) && (octet < 192))  /* bad (starts with 10xxxxxx). */
	{
		/*
		 * Apparently each of these is supposed to be flagged as a bogus
		 *	char, instead of just resyncing to the next valid codepoint.
		 */
		(*_str)++;	/* skip to next possible start of codepoint. */
		return UNICODE_BOGUS_CHAR_VALUE;
	} /* else if */

	else if (octet < 224)  /* two octets */
	{
		octet -= (128+64);
		octet2 = (u32) ((u8) *(++str));
		if ((octet2 & (128+64)) != 128)  /* Format isn't 10xxxxxx? */
			return UNICODE_BOGUS_CHAR_VALUE;

		*_str += 2;  /* skip to next possible start of codepoint. */
		retval = ((octet << 6) | (octet2 - 128));
		if ((retval >= 0x80) && (retval <= 0x7FF))
			return retval;
	} /* else if */

	else if (octet < 240)  /* three octets */
	{
		octet -= (128+64+32);
		octet2 = (u32) ((u8) *(++str));
		if ((octet2 & (128+64)) != 128)  /* Format isn't 10xxxxxx? */
			return UNICODE_BOGUS_CHAR_VALUE;

		octet3 = (u32) ((u8) *(++str));
		if ((octet3 & (128+64)) != 128)  /* Format isn't 10xxxxxx? */
			return UNICODE_BOGUS_CHAR_VALUE;

		*_str += 3;  /* skip to next possible start of codepoint. */
		retval = ( ((octet << 12)) | ((octet2-128) << 6) | ((octet3-128)) );

		/* There are seven "UTF-16 surrogates" that are illegal in UTF-8. */
		switch (retval)
		{
			case 0xD800:
			case 0xDB7F:
			case 0xDB80:
			case 0xDBFF:
			case 0xDC00:
			case 0xDF80:
			case 0xDFFF:
				return UNICODE_BOGUS_CHAR_VALUE;
		} /* switch */

		/* 0xFFFE and 0xFFFF are illegal, too, so we check them at the edge. */
		if ((retval >= 0x800) && (retval <= 0xFFFD))
			return retval;
	} /* else if */

	else if (octet < 248)  /* four octets */
	{
		octet -= (128+64+32+16);
		octet2 = (u32) ((u8) *(++str));
		if ((octet2 & (128+64)) != 128)  /* Format isn't 10xxxxxx? */
			return UNICODE_BOGUS_CHAR_VALUE;

		octet3 = (u32) ((u8) *(++str));
		if ((octet3 & (128+64)) != 128)  /* Format isn't 10xxxxxx? */
			return UNICODE_BOGUS_CHAR_VALUE;

		octet4 = (u32) ((u8) *(++str));
		if ((octet4 & (128+64)) != 128)  /* Format isn't 10xxxxxx? */
			return UNICODE_BOGUS_CHAR_VALUE;

		*_str += 4;  /* skip to next possible start of codepoint. */
		retval = ( ((octet << 18)) | ((octet2 - 128) << 12) |
				   ((octet3 - 128) << 6) | ((octet4 - 128)) );
		if ((retval >= 0x10000) && (retval <= 0x10FFFF))
			return retval;
	} /* else if */

	/*
	 * Five and six octet sequences became illegal in rfc3629.
	 *	We throw the codepoint away, but parse them to make sure we move
	 *	ahead the right number of bytes and don't overflow the buffer.
	 */

	else if (octet < 252)  /* five octets */
	{
		octet = (u32) ((u8) *(++str));
		if ((octet & (128+64)) != 128)	/* Format isn't 10xxxxxx? */
			return UNICODE_BOGUS_CHAR_VALUE;

		octet = (u32) ((u8) *(++str));
		if ((octet & (128+64)) != 128)	/* Format isn't 10xxxxxx? */
			return UNICODE_BOGUS_CHAR_VALUE;

		octet = (u32) ((u8) *(++str));
		if ((octet & (128+64)) != 128)	/* Format isn't 10xxxxxx? */
			return UNICODE_BOGUS_CHAR_VALUE;

		octet = (u32) ((u8) *(++str));
		if ((octet & (128+64)) != 128)	/* Format isn't 10xxxxxx? */
			return UNICODE_BOGUS_CHAR_VALUE;

		*_str += 5;  /* skip to next possible start of codepoint. */
		return UNICODE_BOGUS_CHAR_VALUE;
	} /* else if */

	else  /* six octets */
	{
		octet = (u32) ((u8) *(++str));
		if ((octet & (128+64)) != 128)	/* Format isn't 10xxxxxx? */
			return UNICODE_BOGUS_CHAR_VALUE;

		octet = (u32) ((u8) *(++str));
		if ((octet & (128+64)) != 128)	/* Format isn't 10xxxxxx? */
			return UNICODE_BOGUS_CHAR_VALUE;

		octet = (u32) ((u8) *(++str));
		if ((octet & (128+64)) != 128)	/* Format isn't 10xxxxxx? */
			return UNICODE_BOGUS_CHAR_VALUE;

		octet = (u32) ((u8) *(++str));
		if ((octet & (128+64)) != 128)	/* Format isn't 10xxxxxx? */
			return UNICODE_BOGUS_CHAR_VALUE;

		octet = (u32) ((u8) *(++str));
		if ((octet & (128+64)) != 128)	/* Format isn't 10xxxxxx? */
			return UNICODE_BOGUS_CHAR_VALUE;

		*_str += 6;  /* skip to next possible start of codepoint. */
		return UNICODE_BOGUS_CHAR_VALUE;
	} /* else if */

	return UNICODE_BOGUS_CHAR_VALUE;
} /* utf8codepoint */


static void PHYSFS_utf8ToUcs4(const char *src, u32 *dst, u64 len)
{
	len -= sizeof (u32);   /* save room for null char. */
	while (len >= sizeof (u32))
	{
		u32 cp = utf8codepoint(&src);
		if (cp == 0)
			break;
		else if (cp == UNICODE_BOGUS_CHAR_VALUE)
			cp = UNICODE_BOGUS_CHAR_CODEPOINT;
		*(dst++) = cp;
		len -= sizeof (u32);
	} /* while */

	*dst = 0;
} /* PHYSFS_utf8ToUcs4 */


static void PHYSFS_utf8ToUcs2(const char *src, u16 *dst, u64 len)
{
	len -= sizeof (u16);   /* save room for null char. */
	while (len >= sizeof (u16))
	{
		u32 cp = utf8codepoint(&src);
		if (cp == 0)
			break;
		else if (cp == UNICODE_BOGUS_CHAR_VALUE)
			cp = UNICODE_BOGUS_CHAR_CODEPOINT;

		/* !!! BLUESKY: UTF-16 surrogates? */
		if (cp > 0xFFFF)
			cp = UNICODE_BOGUS_CHAR_CODEPOINT;

		*(dst++) = cp;
		len -= sizeof (u16);
	} /* while */

	*dst = 0;
} /* PHYSFS_utf8ToUcs2 */

static void utf8fromcodepoint(u32 cp, char **_dst, u64 *_len)
{
	char *dst = *_dst;
	u64 len = *_len;

	if (len == 0)
		return;

	if (cp > 0x10FFFF)
		cp = UNICODE_BOGUS_CHAR_CODEPOINT;
	else if ((cp == 0xFFFE) || (cp == 0xFFFF))	/* illegal values. */
		cp = UNICODE_BOGUS_CHAR_CODEPOINT;
	else
	{
		/* There are seven "UTF-16 surrogates" that are illegal in UTF-8. */
		switch (cp)
		{
			case 0xD800:
			case 0xDB7F:
			case 0xDB80:
			case 0xDBFF:
			case 0xDC00:
			case 0xDF80:
			case 0xDFFF:
				cp = UNICODE_BOGUS_CHAR_CODEPOINT;
		} /* switch */
	} /* else */

	/* Do the encoding... */
	if (cp < 0x80)
	{
		*(dst++) = (char) cp;
		len--;
	} /* if */

	else if (cp < 0x800)
	{
		if (len < 2)
			len = 0;
		else
		{
			*(dst++) = (char) ((cp >> 6) | 128 | 64);
			*(dst++) = (char) (cp & 0x3F) | 128;
			len -= 2;
		} /* else */
	} /* else if */

	else if (cp < 0x10000)
	{
		if (len < 3)
			len = 0;
		else
		{
			*(dst++) = (char) ((cp >> 12) | 128 | 64 | 32);
			*(dst++) = (char) ((cp >> 6) & 0x3F) | 128;
			*(dst++) = (char) (cp & 0x3F) | 128;
			len -= 3;
		} /* else */
	} /* else if */

	else
	{
		if (len < 4)
			len = 0;
		else
		{
			*(dst++) = (char) ((cp >> 18) | 128 | 64 | 32 | 16);
			*(dst++) = (char) ((cp >> 12) & 0x3F) | 128;
			*(dst++) = (char) ((cp >> 6) & 0x3F) | 128;
			*(dst++) = (char) (cp & 0x3F) | 128;
			len -= 4;
		} /* else if */
	} /* else */

	*_dst = dst;
	*_len = len;
} /* utf8fromcodepoint */

#define UTF8FROMTYPE(typ, src, dst, len) \
	if (len == 0) return; \
	len--;	\
	while (len) \
	{ \
		const u32 cp = (u32) ((typ) (*(src++))); \
		if (cp == 0) break; \
		utf8fromcodepoint(cp, &dst, &len); \
	} \
	*dst = '\0'; \

static void PHYSFS_utf8FromUcs4(const u32 *src, char *dst, u64 len)
{
	UTF8FROMTYPE(u32, src, dst, len);
} /* PHYSFS_utf8FromUcs4 */

static void PHYSFS_utf8FromUcs2(const u16 *src, char *dst, u64 len)
{
	UTF8FROMTYPE(u64, src, dst, len);
} /* PHYSFS_utf8FromUcs4 */

#undef UTF8FROMTYPE

void utf8ToWchar(const char *in, wchar_t *out, const u64 len)
{
#ifdef _WIN32
	PHYSFS_utf8ToUcs2(in, (u16 *) out, len);
#else
	PHYSFS_utf8ToUcs4(in, (u32 *) out, len);
#endif
}

void wcharToUtf8(const wchar_t *in, char *out, const u64 len)
{
#ifdef _WIN32
	PHYSFS_utf8FromUcs2((const u16 *) in, out, len);
#else
	PHYSFS_utf8FromUcs4((const u32 *) in, out, len);
#endif
}

} // end namespace core
} // end namespace irr


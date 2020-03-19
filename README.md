# Okapi.Web.Api.Console
* A Web API service running as a Windows console application for non-Okapi users to use your test automation tools/frameworks to call. It has end-points which perform search-by-anchors to xpath conversions.

## Endpoints
### Search: search by anchors, returning possible xpaths
* Type: POST
* Resource: '/search'
* Input: RequestDTO
* Output: ManagedXPaths object

### Record: return possible xpaths for all usable web elements on a html document
* Type: POST
* Resource: '/record'
* Input: RecordRequestDTO
* Output: ManagedXPaths object

### Count: count all usable web elements in a html document
* Type: POST
* Resource: '/count'
* Input: html content text
* Output: number of the usable web elements in the provided html document

## Usage
* Download the Release folder
* 

# Okapi.Web.Api.Console
* A Web API service running as a Windows console application for non-Okapi users to use your test automation tools/frameworks to call. It has three end-points which perform search-by-anchors to xpath conversions and recording web page xpaths.

## Endpoints
### Search: search by anchors, returning possible xpaths
* Type: POST
* Resource: **/search**
* Input: RequestDTO
* Output: ManagedXPaths object

### Record: return possible xpaths for all usable web elements on a html document
* Type: POST
* Resource: **/record**
* Input: RecordRequestDTO
* Output: ManagedXPaths object

### Count: count all usable web elements in a html document
* Type: POST
* Resource: **/count**
* Input: html content text
* Output: number of the usable web elements in the provided html document

## Usage
* Download the Release folder
* In Windows command, go to the download folder and run **OkapiWebApi.exe**
  * **OkapiWebApi.exe help** --> get help
  * **OkapiWebApi.exe** then hit enter --> run Okapi listening on **http://localhost:4476** (4476 is the default port)
  * **OkapiWebApi.exe -ip your_machine_ip -port your_port** --> run Okapi listening on ip and port specified by you

## Test
* After running **OkapiWebApi.exe**, open a browser and in Address go to **http://localhost:4476/healthcheck**, you should receive '<string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">ok</string>' if things are OK.
  
## Call API endpoints
* See https://github.com/tamnguyenbbt/Okapi.Web.Api.Console/blob/master/Okapi.Web.Api.Console.Test for examples of API calls and the Data Transfer Objects (DTOs) of the API.
* Can use Postman and do some tests as well.

## Dockers
* You can create dockers if needed

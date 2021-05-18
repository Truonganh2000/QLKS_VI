function varargout = untitled(varargin)
% UNTITLED MATLAB code for untitled.fig
%      UNTITLED, by itself, creates a new UNTITLED or raises the existing
%      singleton*.
%
%      H = UNTITLED returns the handle to a new UNTITLED or the handle to
%      the existing singleton*.
%
%      UNTITLED('CALLBACK',hObject,eventData,handles,...) calls the local
%      function named CALLBACK in UNTITLED.M with the given input arguments.
%
%      UNTITLED('Property','Value',...) creates a new UNTITLED or raises the
%      existing singleton*.  Starting from the left, property value pairs are
%      applied to the GUI before untitled_OpeningFcn gets called.  An
%      unrecognized property name or invalid value makes property application
%      stop.  All inputs are passed to untitled_OpeningFcn via varargin.
%
%      *See GUI Options on GUIDE's Tools menu.  Choose "GUI allows only one
%      instance to run (singleton)".
%
% See also: GUIDE, GUIDATA, GUIHANDLES

% Edit the above text to modify the response to help untitled

% Last Modified by GUIDE v2.5 04-Jan-2021 15:12:31

% Begin initialization code - DO NOT EDIT
gui_Singleton = 1;
gui_State = struct('gui_Name',       mfilename, ...
                   'gui_Singleton',  gui_Singleton, ...
                   'gui_OpeningFcn', @untitled_OpeningFcn, ...
                   'gui_OutputFcn',  @untitled_OutputFcn, ...
                   'gui_LayoutFcn',  [] , ...
                   'gui_Callback',   []);
if nargin && ischar(varargin{1})
    gui_State.gui_Callback = str2func(varargin{1});
end

if nargout
    [varargout{1:nargout}] = gui_mainfcn(gui_State, varargin{:});
else
    gui_mainfcn(gui_State, varargin{:});
end
% End initialization code - DO NOT EDIT


% --- Executes just before untitled is made visible.
function untitled_OpeningFcn(hObject, eventdata, handles, varargin)
% This function has no output args, see OutputFcn.
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
% varargin   command line arguments to untitled (see VARARGIN)

% Choose default command line output for untitled
handles.output = hObject;

% Update handles structure
guidata(hObject, handles);

% UIWAIT makes untitled wait for user response (see UIRESUME)
% uiwait(handles.figure1);


% --- Outputs from this function are returned to the command line.
function varargout = untitled_OutputFcn(hObject, eventdata, handles) 
% varargout  cell array for returning output args (see VARARGOUT);
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Get default command line output from handles structure
varargout{1} = handles.output;


% --- Executes on button press in pushbutton1.
function pushbutton1_Callback(hObject, eventdata, handles)
global hinhanh
[FileName,PathName]=uigetfile('*.jpg;*.png');
fullname=strcat(PathName,FileName);
hinhanh=imread(fullname);
axes(handles.axes1);
imshow(hinhanh);
% hObject    handle to pushbutton1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


% --- Executes on button press in pushbutton2.
function pushbutton2_Callback(hObject, eventdata, handles)
global hinhanh
gray=rgb2gray(hinhanh);
max=ordfilt2(gray,9,ones(3,3));
axes(handles.axes2);
imshow(max);
% hObject    handle to pushbutton2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


% --- Executes on button press in pushbutton3.
function pushbutton3_Callback(hObject, eventdata, handles)
global hinhanh
gray=rgb2gray(hinhanh);
min=ordfilt2(gray,1,ones(3,3));
axes(handles.axes2);
imshow(min);
% hObject    handle to pushbutton3 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


% --- Executes on button press in pushbutton4.
function pushbutton4_Callback(hObject, eventdata, handles)
global hinhanh
gianno=imdilate(hinhanh,ones(3,3));
axes(handles.axes2);
imshow(gianno);
% hObject    handle to pushbutton4 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


% --- Executes on button press in pushbutton5.
function pushbutton5_Callback(hObject, eventdata, handles)
global hinhanh
xoimon=imerode(hinhanh,ones(3,3));
axes(handles.axes2);
imshow(xoimon);
% hObject    handle to pushbutton5 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


% --- Executes on button press in pushbutton6.
function pushbutton6_Callback(hObject, eventdata, handles)
global hinhanh
A=im2double(hinhanh);
[m n]=size(A);
Med=[];
for i=3:m-2
    for j=3:n-2
        q=1;
        for h=-2:2
            for k=-2:2
                Med(q)=A(i+k,j+h);
                q=q+1;
            end
        end
        A(i,j)=median(Med);
    end
end
axes(handles.axes2);
imshow(A);
% hObject    handle to pushbutton6 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


% --- Executes on button press in pushbutton7.
function pushbutton7_Callback(hObject, eventdata, handles)
global hinhanh
A=im2double(hinhanh);
[m n]=size(A);
Med=[];
for i=3:m-2
    for j=3:m-2
        q=1;
        for h=-2:2
            for g=-2:2
                Med(q)=A(i+g,j+h);
                q=q+1;
            end
        end
        sum=0;
        for k=1:25
            sum=sum+Med(k);
        end
        A(i,j)=(sum/25);
    end
end
axes(handles.axes2);
imshow(A);
% hObject    handle to pushbutton7 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


% --- Executes on button press in pushbutton8.
function pushbutton8_Callback(hObject, eventdata, handles)
global hinhanh
gray=rgb2gray(hinhanh);
sobel=edge(gray,'sobel',0.1);
imshow(sobel);
% hObject    handle to pushbutton8 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


% --- Executes on button press in pushbutton9.
function pushbutton9_Callback(hObject, eventdata, handles)
global hinhanh
[m n]=size(hinhanh);
b=double(hinhanh);
w=[1/9 1/9 1/9;1/9 1/9 1/9;1/9 1/9 1/9];
for i=2:1:m-1
    for j=2:1:n-1
        r(i,j)=b(i-1,j-1)*w(1)+b(i-1,j)*w(2)+b(i-1,j+1)*w(3)+b(i,j-1)*w(4)+b(i,j)*w(5)+b(i,j+1)*w(6)+b(i+1,j-1)*w(7)+b(i+1,j)*w(8)+b(i+1,j+1)*w(9);
    end
end
axes(handles.axes2);
imshow(uint8(r));
% hObject    handle to pushbutton9 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


% --- Executes on button press in pushbutton10.
function pushbutton10_Callback(hObject, eventdata, handles)
global hinhanh
b=double(hinhanh);
[m n]=size(hinhanh);
w=[-1/9 -1/9 -1/9;-1/9 -1/9 8/9;-1/9 -1/9 -1/9];
for i=2:1:m-1
    for j=2:1:n-1
        r(i,j)=b(i-1,j-1)*w(1)+b(i-1,j)*w(2)+b(i-1,j+1)*w(3)+b(i,j-1)*w(4)+b(i,j)*w(5)+b(i,j+1)*w(6)+b(i+1,j-1)*w(7)+b(i+1,j)*w(8)+b(i+1,j+1)*w(9);
    end
end
axes(handles.axes2);
imshow(uint8(r));
% hObject    handle to pushbutton10 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


% --- Executes on button press in pushbutton11.
function pushbutton11_Callback(hObject, eventdata, handles)
global hinhanh
img=im2double(hinhanh);
r=img(:,:,1);
g=img(:,:,2);
b=img(:,:,3);
C=1-r;
M=1-g;
Y=1-b;
CMY=cat(3,C,M,Y);
imshow(CMY);
% hObject    handle to pushbutton11 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


% --- Executes on button press in pushbutton12.
function pushbutton12_Callback(hObject, eventdata, handles)
global hinhanh
gray=rgb2gray(hinhanh);
rank=ordfilt2(gray,1,ones(3,3));
axes(handles.axes2);
imshow(rank);
% hObject    handle to pushbutton12 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


% --- Executes on button press in pushbutton13.
function pushbutton13_Callback(hObject, eventdata, handles)
global hinhanh
amban=imcomplement(hinhanh);
axes(handles.axes2);
imshow(amban)
% hObject    handle to pushbutton13 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


% --- Executes on button press in pushbutton14.
function pushbutton14_Callback(hObject, eventdata, handles)
global hinhanh
gray=rgb2gray(hinhanh)
nguong=im2bw(gray,0.5);
axes(handles.axes2);
imshow(nguong);
% hObject    handle to pushbutton14 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
